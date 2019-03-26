using System;
using CoreMapWebservice;

namespace BaiduMapWebservice.Request.Models
{
    public class PlaceRectangeModel: PlaceModel
    {
        [Required]
        public string Bounds { get; set; }
    }
}
