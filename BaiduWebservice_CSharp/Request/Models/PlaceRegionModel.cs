﻿using System;
using Mapservice_Core;

namespace BaiduMap.Request.Models
{
    public class PlaceRegionModel: PlaceModel
    {
        [Required]
        public string Region { get; set; }
        public string City_Limit { get; set; }
    }
}
