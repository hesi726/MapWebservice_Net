using BaiduMapWebservice.Response.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Response
{
    public class IPLocationResponse: BaiduResponse
    {
        public string Address { get; set; }
        public IPContent Content { get; set; }
    }
}
