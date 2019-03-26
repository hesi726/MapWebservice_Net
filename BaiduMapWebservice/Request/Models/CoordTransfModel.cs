using System;
using CoreMapWebservice;

namespace BaiduMapWebservice.Request.Models
{
    public class CoordTransfModel : BaiduModel
    {
        /// <summary>
        /// 经度在前，维度在后; 例如 113.1234123,23.125125
        /// </summary>
        [Required]
        public string Coords { get; set; }
        public int? From { get; set; }
        public int? To { get; set; }

        public const int From_GPS_WSG84 = 1;
        public const int From_SOGOU = 2;
        public const int From_AMAP = 3;
        public const int From_MAPBAR = 7;
        public const int From_51 = 8;
    }
}
