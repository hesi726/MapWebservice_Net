using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Response.Models
{
    public class PlaceDetailItem
    {
        public string Name { get; set; }
        public Location Location { get; set; }
        public string Address { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string Street_Id { get; set; }
        public string Telephone { get; set; }
        public int? Detail { get; set; }
        public string Uid { get; set; }
    }
}
