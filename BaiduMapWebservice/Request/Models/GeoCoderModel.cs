using CoreMapWebservice;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Request.Models
{
    public class GeoCoderModel : BaiduModel
    {
        [Required]
        public string Address { get; set; }
        public string City { get; set; }
        public string Ret_Coordtype { get; set; }
    }
}
