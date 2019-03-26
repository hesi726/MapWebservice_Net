using CoreMapWebservice;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Request.Models
{
    public class PublicPlanModel : BaiduModel
    {
        [Required]
        public string Origin { get; set; }
        [Required]
        public string Destination { get; set; }
        public string Coord_Type { get; set; }
        public int? Tactics_Incity { get; set; }
        public int? Tactics_Intercity { get; set; }
        public int? Trans_Type_Intercity { get; set; }
        public string Ret_CoordType { get; set; }
        public int? Page_Size { get; set; }
        public int? Page_Index { get; set; }
        public string Timestamp { get; set; }
        public string Callback { get; set; }
    }
}

