using BaiduMapWebservice.Request;
using BaiduMapWebservice.Response;
using CoreMapWebservice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduMapWebservice.Util
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
        /// 根据AppKey,SecretKey、Url、参数计算Sk
        /// </summary>
        /// <param name="ak"></param>
        /// <param name="sk"></param>
        /// <param name="url"></param>
        /// <param name="querystring_arrays"></param>
        /// <returns></returns>
        public static string CaculateAKSN(string ak, string sk, string url, IDictionary<string, string> querystring_arrays)
        {
            var queryString = DictionaryUtil.HttpBuildQuery(querystring_arrays);
            var str = DictionaryUtil.UrlEncode(url + "?" + queryString + sk);
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
        public static string BuildQueryStringWithAkAndSn<T>(IRequest<T> request, string ak, string sk)
            where T :IResponse
        {
            var dictionary = request.GetParameters();
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

            var querystring = DictionaryUtil.HttpBuildQuery(dictionary);
            return querystring;
        }

       
    }
}
