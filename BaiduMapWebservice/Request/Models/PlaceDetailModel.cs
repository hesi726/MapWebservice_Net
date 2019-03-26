
using CoreMapWebservice;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Request.Models
{
    public class PlaceDetailModel : BaiduModel
    {
        [Required]
        public string Uid { get; set; }
        public string Uids { get; set; }
        public string Scope { get; set; }
    }
}
