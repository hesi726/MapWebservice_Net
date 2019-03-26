using BaiduMapWebservice.Request;
using BaiduMapWebservice.Response;
using System.Net.Http;
using Newtonsoft.Json;
using BaiduMapWebservice.Request.Models;
using System.Threading.Tasks;
using System;
using BaiduMapWebservice.Util;
using CoreMapWebservice;

namespace BaiduMapWebservice
{
    /// <summary>
    /// 百度地图的客户端;
    /// </summary>
    public class BaiduMapClient : AbstractWebClient
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
        /// 构建查询字符串
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public override string BuildQueryString<TResponse>(IRequest<TResponse> request)
        {
            return AKSNCaculater.BuildQueryStringWithAkAndSn(request, Ak, Sk);
        }
    }
}
