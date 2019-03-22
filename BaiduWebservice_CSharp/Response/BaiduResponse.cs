using Mapservice_Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BaiduMap.Response
{
    /// <summary>
    /// 百度的响应类;
    /// </summary>
    public abstract class BaiduResponse : AbstractResponse
    {
        public int Status { get; set; }
        public string Message { get; set; }
    }
}
