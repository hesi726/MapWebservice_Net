using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Response.Models
{
    public class RideStep
    {
        public int? Area { get; set; }
        public int? Direction { get; set; }
        public int? Distance { get; set; }
        public int? Duration { get; set; }
        public string Instructions { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }
        public string Turn_Type { get; set; }
        public Location StepOriginLocation { get; set; }
        public Location StepDestinationLocation { get; set; }
    }
}
