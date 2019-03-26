using System;
using System.Collections.Generic;
using System.Text;

namespace AMapWebservice.Response.Model
{
    /// <summary>
    /// 地址解析成坐标后的地理信息;
    /// </summary>
    public class GeoDetailItem
    {
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, Geocode> geocodes { get; set; }
    }
}
