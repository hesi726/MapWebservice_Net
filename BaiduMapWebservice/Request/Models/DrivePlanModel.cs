using CoreMapWebservice;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Request.Models
{
    public class DrivePlanModel : BaiduModel
    {
        [Required]
        public string Origin { get; set; }
        [Required]
        public string Destination { get; set; }
        public string Origin_Uid { get; set; }
        public string Destination_Uid { get; set; }
        public string WayPoints { get; set; }
        public string Coord_Type { get; set; }
        public string Ret_CoordType { get; set; }
        public string Tactics { get; set; }
        public string Alternatives { get; set; }
        public string Plate_Number { get; set; }
        public string Ext_Departure_Time { get; set; }
        public string GPS_Direction { get; set; }
        public double? Radius { get; set; }
        public double? Speed { get; set; }
        public string Timestamp { get; set; }
        public string CallBack { get; set; }
    }
}
