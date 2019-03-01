using System;
using System.Collections.Generic;
using System.Reflection;
using BaiduMap.Attributes;
using BaiduMap.Exceptions;
using BaiduMap.Request.Models;

namespace BaiduMap.Util
{
    public static class DictionaryUtil
    {

        public static Dictionary<string, string> GetDictionary(BaiduModel model)
        {
            return GetDictionary(model, Strategy.IgnoreNullOrEmpty);
        }

        public static Dictionary<string, string> GetDictionary(BaiduModel model, Strategy strategy) 
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
        /// 获取参数表的策略
        /// </summary>
        public enum Strategy
        {
            IgnoreNullOrEmpty,
            Normal
        }
    }
}
