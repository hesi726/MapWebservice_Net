using BaiduMap.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMap.Request
{
    public interface IBaiduRequest<T> where T: BaiduResponse
    {
        string Host { get; }
        string Address { get; }
        Dictionary<string, string> GetParameters();
        bool RequiredTimestamp { get; }
    }
}
