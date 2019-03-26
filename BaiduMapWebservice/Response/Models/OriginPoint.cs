using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Response.Models
{
    public class OriginPoint
    {
        public string Area_Id { get; set; }
        public string Cname { get; set; }
        public string Uid { get; set; }
        public string Wd { get; set; }
        public Location OriginPt { get; set; }
    }
}
