using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Response.Models
{
    public class VehicleDetail
    {
        public string Name { get; set; }
        public double? Price { get; set; }
        public string Booking { get; set; }
        public string Departure_Station { get; set; }
        public string Arrive_Station { get; set; }
        public string Departure_Time { get; set; }
        public string Arrive_Time { get; set; }
        public StartInfo Start_Info { get; set; }
        public EndInfo End_Info { get; set; }

        #region 飞机字段
        public double? Discount { get; set; }
        public string AirLines { get; set; }
        #endregion

        #region 公交字段
        public int? Type { get; set; }
        public int? Stop_Num { get; set; }
        public string On_Station { get; set; }
        public string Off_Station { get; set; }
        public string First_Time { get; set; }
        public string Last_Time { get; set; }
        #endregion

        #region 大巴字段
        public string Provider_Name { get; set; }
        public string Provider_Url { get; set; }
        #endregion
    }
}
