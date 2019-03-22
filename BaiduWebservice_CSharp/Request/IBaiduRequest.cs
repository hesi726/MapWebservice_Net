using BaiduMap.Response;
using Mapservice_Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMap.Request
{
    /// <summary>
    /// 地图的请求接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaiduRequest<TResponse> : IRequest<TResponse>
        where TResponse : BaiduResponse
    {       
        /// <summary>
        /// 是否需要时间戳;
        /// </summary>
        bool RequiredTimestamp { get; }
    }
}
