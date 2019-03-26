using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Response.Models
{
    public class DriveRoute
    {
        public Location Origin { get; set; }
        public Location Destination { get; set; }
        public string Tag { get; set; }
        public int? Distance { get; set; }
        public int? Duration { get; set; }
        public int? Ext_Duration { get; set; }
        public int? Taxi_Fee { get; set; }
        public int? Toll { get; set; }
        public int? Toll_Distance { get; set; }
        public List<DriveStep> Steps { get; set; }
    }
}
