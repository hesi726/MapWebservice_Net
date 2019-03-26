using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Response.Models
{
    public class PlaceSuggestionItem
    {
        public string Name { get; set; }
        public Location Location { get; set; }
        public string Uid { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Business { get; set; }
        public string CityId { get; set; }
    }
}
