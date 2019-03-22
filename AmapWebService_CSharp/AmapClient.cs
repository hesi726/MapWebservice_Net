using AMap.Json;
using Mapservice_Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmapWebService_CSharp
{
    /// <summary>
    /// 高德地图的客户端;
    /// </summary>
    public class AMapClient : AbstractWebClient
    {
        /// <summary>
        /// 只带有 ak 的构造函数;
        /// </summary>
        /// <param name="AppKey">appKey</param>
        internal AMapClient(string AppKey)
        {
            this.AppKey = AppKey;
        }

        /// <summary>
        /// 高德地图的键;
        /// </summary>
        public string AppKey { get; set; }

        public override Dictionary<string, string> BuildQueryParameter<TResponse>(IRequest<TResponse> request)
        {
            var result = base.BuildQueryParameter(request);
            result.Add("key", this.AppKey);
            return result;
        }

        public override T DeserialzeObject<T>(string json)
        {
            JsonConverter[] converts = new JsonConverter[]
            {
                new StringOrStringArrayConvert()
            };
            var result = JsonConvert.DeserializeObject<T>(json, converts);
            result.Meta = json;
            return result;
        }

    }
}
