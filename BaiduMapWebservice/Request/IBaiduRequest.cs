using BaiduMapWebservice.Response;
using CoreMapWebservice;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Request
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
