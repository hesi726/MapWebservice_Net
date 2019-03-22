using System;
using System.Collections.Generic;
using System.Text;

namespace Mapservice_Core
{
    /// <summary>
    /// 
    /// </summary>
    public interface IResponse
    {
        /// <summary>
        /// 响应中的原始数据
        /// </summary>
        string Meta { get; set; }
    }
}
