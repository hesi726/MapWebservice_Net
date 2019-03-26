using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Response.Models
{
    public class TrafficCondition
    {
        public string Status { get; set; }
        public int? Geo_Cnt { get; set; }
        public double? Distance { get; set; }
    }
}
