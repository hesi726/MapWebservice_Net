using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Response.Models
{
    public class DriveStep
    {
        public int? Leg_Index { get; set; }
        public string Direction { get; set; }
        public double? Distance { get; set; }
        public string Road_Name { get; set; }
        public string Road_Type { get; set; }
        public int? Toll { get; set; }
        public int? Toll_Distance { get; set; }
        public string Toll_Gate_Name { get; set; }
        public Location Toll_Gate_Location { get; set; }
        public Location Start_Location { get; set; }
        public Location End_Location { get; set; }
        public string Path { get; set; }
        public List<TrafficCondition> Traffic_Condition { get; set; }

    }
}
