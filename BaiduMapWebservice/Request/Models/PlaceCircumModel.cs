using System;
using CoreMapWebservice;

namespace BaiduMapWebservice.Request.Models
{
    public class PlaceCircumModel : PlaceModel
    {
        
        [Required]
        public string Location { get; set; }
        public string Radius { get; set; }
        public string Radius_Limit { get; set; }

    }
}
