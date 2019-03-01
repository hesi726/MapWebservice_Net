using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMap.Response
{
    public abstract class BaiduListResultsResponse<T>: BaiduResponse
    {
        public int? Total { get; set; }
        public List<T> Results { get; set; }
        
    }
}
