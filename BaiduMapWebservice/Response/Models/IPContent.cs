using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Response.Models
{
    public class IPContent
    {
        public IPDetail Address_Detail { get; set; }
        public string Address { get; set; }
        public IPPoint Point { get; set; }
    }
}
