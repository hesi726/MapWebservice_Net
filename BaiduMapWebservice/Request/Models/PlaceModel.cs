using System;
using CoreMapWebservice;

namespace BaiduMapWebservice.Request.Models
{
    public abstract class PlaceModel: BaiduModel
    {
        [Required]
        public string Query { get; set; }
        public string Tag { get; set; }
        
        public string Scope { get; set; }
        public string Filter { get; set; }
        public int? Coord_Type { get; set; }
        public string Ret_Coordtype { get; set; }
        public int? Page_Size { get; set; }
        public int? Page_Num { get; set; }
    }
}
