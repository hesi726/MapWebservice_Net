using System;
using CoreMapWebservice;

namespace BaiduMapWebservice.Request.Models
{
    public class PlaceRegionModel: PlaceModel
    {
        [Required]
        public string Region { get; set; }
        public string City_Limit { get; set; }
    }
}
