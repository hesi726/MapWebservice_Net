using BaiduMap.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMap.Request.Models
{
    public class PlaceDetailModel : BaiduModel
    {
        [Required]
        public string Uid { get; set; }
        public string Uids { get; set; }
        public string Scope { get; set; }
    }
}
