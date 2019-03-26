using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoreMapWebservice
{
    /// <summary>
    /// Webservice 的客户端;
    /// </summary>
    public abstract class AbstractWebClient
    {
        /// <summary>
        /// 执行查询接口，根据构造函数sk值的不同，调用不同验证方式的接口
        /// 如果sk为空，调用 ip白名单验证
        /// 否则调用sn验证方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="S"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public T Execute<T>(IRequest<T> request)
            where T : IResponse
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
        public Task<T> ExecuteAsync<T>(IRequest<T> request)
            where T : IResponse
        {
            return Task.Run(() => Execute(request));
        }

        /// <summary>
        /// 返回字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public string ExecuteReadString<T>(IRequest<T> request)
            where T : IResponse
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
        public Task<string> ExecuteReadStringAsync<T>(IRequest<T> request)
            where T : IResponse
        {
            return Task.Run(() => ExecuteReadString(request));
        }



        /// <summary>
        /// 根据 host、url、以及 queryString 获取返回结果字符串
        /// </summary>
        /// <param name="host"></param>
        /// <param name="address"></param>
        /// <param name="queryString"></param>
        /// <returns></returns>
        protected string GetResponseString(string host, string address, string queryString)
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
        protected T GetResponse<T>(string host, string address, string queryString)
            where T : IResponse
        {
            var respString = GetResponseString(host, address, queryString);
            return DeserialzeObject<T>(respString);
        }

        public virtual T DeserialzeObject<T>(string json)
            where T : IResponse
        {
            var result = JsonConvert.DeserializeObject<T>(json);
            result.Meta = json;
            return result;
        }

        /// <summary>
        /// 构建查询字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public virtual Dictionary<string, string> BuildQueryParameter<TResponse>(IRequest<TResponse> request)
            where TResponse : IResponse
        {
            return request.GetParameters();
        }

        /// <summary>
        /// 构建查询字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public virtual string BuildQueryString<TResponse>(IRequest<TResponse> request)
            where TResponse : IResponse
        {
            var dictionary = BuildQueryParameter(request);
            return DictionaryUtil.HttpBuildQuery(dictionary);
        }



    }
}
