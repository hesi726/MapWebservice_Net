using System;
using BaiduMap.Attributes;

namespace BaiduMap.Request.Models
{
    public class PlaceRectangeModel: PlaceModel
    {
        [Required]
        public string Bounds { get; set; }
    }
}
