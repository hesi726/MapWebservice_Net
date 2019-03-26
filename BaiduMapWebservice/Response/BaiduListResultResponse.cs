using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Response
{
    public abstract class BaiduListResultResponse<T> : BaiduResponse
    {
        public int? Total { get; set; }
        public List<T> Result { get; set; }
    }
}
