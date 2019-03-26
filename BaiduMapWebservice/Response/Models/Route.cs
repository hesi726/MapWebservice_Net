using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Response.Models
{
    public class Route
    {
        public int? Distance { get; set; }
        public int? Duration { get; set; }
        public string Arrive_Time { get; set; }
        public double? Price { get; set; }
        public List<PriceDetail> Price_Detail { get; set; }
        public List<List<RouteScheme>> Steps { get; set; }
    }
}
