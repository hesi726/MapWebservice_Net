using AMap.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMap.Response
{
    public abstract class AMapSingleResponse<T> : AMapResponse
    {
        public T Result { get; set; }
    }
}
