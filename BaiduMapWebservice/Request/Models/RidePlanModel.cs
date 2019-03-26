using CoreMapWebservice;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Request.Models
{
    public class RidePlanModel : BaiduModel
    {
        [Required]
        public string Origin { get; set; }
        [Required]
        public string Destination { get; set; }
        public string Coord_Type { get; set; }
        public string Ret_CoordType { get; set; }
        public string Riding_Type { get; set; }
        public string Timestamp { get; set; }
        public string CallBack { get; set; }
    }
}
