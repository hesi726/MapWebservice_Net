using System;
using Mapservice_Core;

namespace BaiduMap.Request.Models
{
    public class PlaceRectangeModel: PlaceModel
    {
        [Required]
        public string Bounds { get; set; }
    }
}
