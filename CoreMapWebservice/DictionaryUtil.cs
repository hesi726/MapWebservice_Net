using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using CoreMapWebservice.Exceptions;

namespace CoreMapWebservice
{
    public static class DictionaryUtil
    {
        /// <summary>
        /// 获取给定对象的属性和值;
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static Dictionary<string, string> GetDictionary(object model)
        {
            return GetDictionary(model, Strategy.IgnoreNullOrEmpty);
        }

        /// <summary>
        /// 获取给定对象的属性和值;
        /// </summary>
        /// <param name="model"></param>
        /// <param name="strategy"></param>
        /// <returns></returns>
        public static Dictionary<string, string> GetDictionary(object model, Strategy strategy) 
        {
            var dictionary = new Dictionary<string, string>();
            var properties = model.GetType().GetProperties(BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.Instance);
            foreach(var property in properties)
            {
                var key = property.Name.ToLower();
                var value = property.GetValue(model)?.ToString();

                // 验证必填的参数是否有值，如果验证未通过，抛出异常
                RequiredAttribute required = property.GetCustomAttribute<RequiredAttribute>();
                if (required != null && required.Value && string.IsNullOrWhiteSpace(value))
                {
                    throw new NullOrEmptyException(property);
                }

                if(strategy == Strategy.Normal) 
                {
                    dictionary.Add(key, value);
                }
                else if (!string.IsNullOrWhiteSpace(value))
                {
                    dictionary.Add(key, value);
                }

            }
            return dictionary;
        }

        /// <summary>
        /// 构建查询参数;
        /// </summary>
        /// <param name="querystring_arrays"></param>
        /// <returns></returns>
        public static string HttpBuildQuery(IDictionary<string, string> querystring_arrays)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in querystring_arrays)
            {
                sb.Append(UrlEncode(item.Key));
                sb.Append("=");
                sb.Append(UrlEncode(item.Value));
                sb.Append("&");
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

        /// <summary>
        /// Url编码;
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string UrlEncode(string str)
        {
            str = System.Web.HttpUtility.UrlEncode(str);
            byte[] buf = Encoding.ASCII.GetBytes(str);//等同于Encoding.ASCII.GetBytes(str)
            for (int i = 0; i < buf.Length; i++)
                if (buf[i] == '%')
                {
                    if (buf[i + 1] >= 'a') buf[i + 1] -= 32;
                    if (buf[i + 2] >= 'a') buf[i + 2] -= 32;
                    i += 2;
                }
            return Encoding.ASCII.GetString(buf);//同上，等同于Encoding.ASCII.GetString(buf)
        }


        /// <summary>
        /// 获取参数表的策略
        /// </summary>
        public enum Strategy
        {
            IgnoreNullOrEmpty,
            Normal
        }
    }
}
