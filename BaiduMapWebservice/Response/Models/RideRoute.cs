using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Response.Models
{
    public class RideRoute
    {
        public string Distance { get; set; }
        public string Duration { get; set; }
        public List<RideStep> Steps { get; set; }
        public Location OriginLocation { get; set; }
        public Location DestinationLocation { get; set; }
    }
}
