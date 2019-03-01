using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMap.Response.Models
{
    public class TaxiDetail
    {
        public string Desc { get; set; }
        public double? Km_Price { get; set; }
        public double? Start_Price { get; set; }
        public double? Total_Price { get; set; }
    }
}
