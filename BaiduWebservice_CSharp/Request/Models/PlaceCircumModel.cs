﻿using System;
using Mapservice_Core;

namespace BaiduMap.Request.Models
{
    public class PlaceCircumModel : PlaceModel
    {
        
        [Required]
        public string Location { get; set; }
        public string Radius { get; set; }
        public string Radius_Limit { get; set; }

    }
}
