using BaiduMap.Extensions;
using BaiduMap.Request;
using BaiduMap.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduMap.Util
{
    /// <summary>
    /// http://lbsyun.baidu.com/index.php?title=webapi/appendix
    /// </summary>
    public static class AKSNCaculater
    {
        /// <summary>
        /// 进行 Md5 解密;
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private static string MD5(string password)
        {
            byte[] textBytes = System.Text.Encoding.UTF8.GetBytes(password);
            try
            {
                System.Security.Cryptography.MD5CryptoServiceProvider cryptHandler;
                cryptHandler = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] hash = cryptHandler.ComputeHash(textBytes);
                string ret = "";
                foreach (byte a in hash)
                {
                    ret += a.ToString("x2");
                }
                return ret;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Url编码;
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string UrlEncode(string str)
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
        /// 构建查询参数;
        /// </summary>
        /// <param name="querystring_arrays"></param>
        /// <returns></returns>
        private static string HttpBuildQuery(IDictionary<string, string> querystring_arrays)
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
        /// 根据AppKey,SecretKey、Url、参数计算Sk
        /// </summary>
        /// <param name="ak"></param>
        /// <param name="sk"></param>
        /// <param name="url"></param>
        /// <param name="querystring_arrays"></param>
        /// <returns></returns>
        public static string CaculateAKSN(string ak, string sk, string url, IDictionary<string, string> querystring_arrays)
        {
            var queryString = HttpBuildQuery(querystring_arrays);
            var str = UrlEncode(url + "?" + queryString + sk);
            return MD5(str);
        }

        /// <summary>
        /// 构建SN查询字符串
        /// http://lbsyun.baidu.com/index.php?title=webapi/appendix
        /// 计算sn跟参数对出现顺序有关，get请求请使用LinkedHashMap保存<key,value>，
        /// 该方法根据key的插入顺序排序；
        /// post请使用TreeMap保存<key,value>，该方法会自动将key按照字母a-z顺序排序。
        /// 所以get请求可自定义参数顺序（sn参数必须在最后）发送请求，
        /// 但是post请求必须按照字母a-z顺序填充body（sn参数必须在最后）。
        /// 以get请求为例：http://api.map.baidu.com/geocoder/v2/?address=百度大厦&output=json&ak=yourak，paramsMap中先放入address，
        /// 再放output，然后放ak，
        /// 放入顺序必须跟get请求中对应参数的出现顺序保持一致。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public static string BuildQueryStringWithAkAndSn<T>(IBaiduRequest<T> request, string ak, string sk)
            where T : BaiduResponse
        {
            var dictionary = request.GetParameters();
            if (request.RequiredTimestamp)
            {
                // 用户未设置timestamp时自动增加，若已经设置timestamp，则使用用户设置的值
                if (!dictionary.ContainsKey("timestamp"))
                {
                    dictionary.Add("timestamp", DateTime.Now.ToTimestamp().ToString());
                }
            }
            // ak 必须是 dictionary中的最后一个参数
            if (dictionary.ContainsKey("ak"))
            {
                dictionary.Remove("ak");
            }
            dictionary.Add("ak", ak);
            // 计算sn时 dictionary不能有 sn
            if (dictionary.ContainsKey("sn"))
            {
                dictionary.Remove("sn");
            }
            var sn = CaculateAKSN(ak, sk, request.Address, dictionary);
            dictionary.Add("sn", sn);

            var querystring = HttpBuildQuery(dictionary);
            return querystring;
        }

       
    }
}
