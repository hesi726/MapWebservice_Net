using System;
using System.Collections.Generic;
using System.Text;

namespace CoreMapWebservice
{
    /// <summary>
    /// 请求的信息类;
    /// </summary>
    public interface IRequest<TResponse>
        where TResponse: IResponse
    {
        /// <summary>
        /// 主机名称
        /// </summary>
        string Host { get; }

        /// <summary>
        /// 请求的Route
        /// </summary>
        string Address { get; }

        bool RequiredTimestamp { get; }

        /// <summary>
        /// 请求的参数
        /// </summary>
        /// <returns></returns>
        Dictionary<string, string> GetParameters();        
    }
}
