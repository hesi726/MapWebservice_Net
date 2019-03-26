using CoreMapWebservice;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Request.Models
{
    public class PlaceSuggestionModel: BaiduModel
    {
        [Required]
        public string Query { get; set; }
        [Required]
        public string Region { get; set; }
        public bool City_Limit { get; set; }
        public string Location { get; set; }
        public int? Coord_Type { get; set; }
        public string Ret_Coordtype { get; set; }
    }
}
