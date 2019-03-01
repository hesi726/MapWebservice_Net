using BaiduMap.Response.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMap.Response
{
    public class IPLocationResponse: BaiduResponse
    {
        public string Address { get; set; }
        public IPContent Content { get; set; }
    }
}
