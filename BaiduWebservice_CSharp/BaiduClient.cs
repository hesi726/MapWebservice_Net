using BaiduMap.Request;
using BaiduMap.Response;
using System.Net.Http;
using Newtonsoft.Json;
using BaiduMap.Request.Models;
using System.Threading.Tasks;
using System;
using BaiduMap.Extensions;
using BaiduMap.Util;

namespace BaiduMap
{
    /// <summary>
    /// 百度地图的客户端;
    /// </summary>
    public class BaiduMapClient
    {
        /// <summary>
        /// appKey
        /// </summary>
        public string Ak { get; private set; }

        /// <summary>
        /// 用于加密的 Sscret Key
        /// </summary>
        public string Sk { get; private set; }

        /// <summary>
        /// 只带有 ak 的构造函数;
        /// </summary>
        /// <param name="ak">appKey</param>
        internal BaiduMapClient(string ak) 
        {
            this.Ak = ak;
        }

        /// <summary>
        /// 带有 ak 和 sk 的构造函数;
        /// </summary>
        /// <param name="ak">appKey</param>
        /// <param name="sk">secretKey</param>
        internal BaiduMapClient(string ak, string sk) : this(ak)
        {
            this.Sk = sk;
        }

        /// <summary>
        /// 执行查询接口，根据构造函数sk值的不同，调用不同验证方式的接口
        /// 如果sk为空，调用 ip白名单验证
        /// 否则调用sn验证方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="S"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public T Execute<T>(IBaiduRequest<T> request)
            where T : BaiduResponse
        {
            var queryString = BuildQueryString(request);
            return GetResponse<T>(request.Host, request.Address, queryString);
        }

        /// <summary>
        /// 异步调用接口
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<T> ExecuteAsync<T>(IBaiduRequest<T> request)
            where T: BaiduResponse
        {
            return Task.Run(() => Execute(request));
        }

        /// <summary>
        /// 返回字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public string ExecuteReadString<T>(IBaiduRequest<T> request)
            where T: BaiduResponse
        {
            var queryString = BuildQueryString(request);
            return GetResponseString(request.Host, request.Address, queryString);
        }

        /// <summary>
        /// 异步调用返回字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<string> ExecuteReadStringAsync<T>(IBaiduRequest<T> request)
            where T: BaiduResponse
        {
            return Task.Run(() => ExecuteReadString(request));
        }
        
        /// <summary>
        /// 获取返回结果字符串
        /// </summary>
        /// <param name="host"></param>
        /// <param name="address"></param>
        /// <param name="queryString"></param>
        /// <returns></returns>
        private string GetResponseString(string host, string address, string queryString)
        {
            var url = host + address + "?" + queryString;
            var client = new HttpClient();
            return client.GetStringAsync(url).Result;
        }

        /// <summary>
        /// 采用Get方式发送请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="host"></param>
        /// <param name="address"></param>
        /// <param name="queryString"></param>
        /// <returns></returns>
        private T GetResponse<T>(string host, string address, string queryString)
            where T : BaiduResponse
        {
            var respString = GetResponseString(host, address, queryString);
            var result = JsonConvert.DeserializeObject<T>(respString);
            result.Meta = respString;
            return result;
        }

        /// <summary>
        /// 构建查询字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        private string BuildQueryString<T>(IBaiduRequest<T> request)
            where T: BaiduResponse
        {
            return AKSNCaculater.BuildQueryStringWithAkAndSn(request, Ak, Sk);
        }
    }
}
