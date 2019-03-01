using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMap.Response.Models
{
    /// <summary>
    /// 逆地址编码
    /// </summary>
    public class ReGeoDetailItem
    {
        public Location Location { get; set; }

        /// <summary>
        /// 地址;
        /// </summary>
        public string formatted_address { get; set; }

        public AddressComponent addressComponent { get; set; }

        public List<Poi> pois { get; set; }


    }
}
