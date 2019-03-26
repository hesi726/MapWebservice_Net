using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Response.Models
{
    public class RouteScheme
    {
        public int? Distance { get; set; }
        public int? Duration { get; set; }
        public string Instruction { get; set; }
        public string Path { get; set; }
        // 目前无输出，暂用object代替
        public List<object> Traffic_Condition { get; set; }
        public Location Start_Location { get; set; }
        public Location End_Location { get; set; }
        public Vehicle Vehicle_Info { get; set; }
    }
}
