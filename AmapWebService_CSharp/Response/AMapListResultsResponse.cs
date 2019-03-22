using System;
using System.Collections.Generic;
using System.Text;

namespace AMap.Response
{
    public abstract class AMapListResultsResponse<T>: AMapResponse
    {
        public int? Total { get; set; }
        public List<T> Results { get; set; }
        
    }
}
