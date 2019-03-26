using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Response.Models
{
    public class PublicPlanItem
    {
        public City Origin { get; set; }
        public City Destination { get; set; }
        public Taxi Taxi { get; set; }
        public List<Route> Routes { get; set; }
        public int Total { get; set; }
    }
}
