using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Response.Models
{
    public class DestinationPoint
    {
        public string Area_Id { get; set; }
        public string Cname { get; set; }
        public string Uid { get; set; }
        public string Wd { get; set; }
        public Location DestinationPt { get; set; }
    }
}
