using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMap.Response
{
    public abstract class BaiduSingleResponse<T> : BaiduResponse
    {
        public T Result { get; set; }
    }
}
