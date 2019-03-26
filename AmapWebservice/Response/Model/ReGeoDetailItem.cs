using System;
using System.Collections.Generic;
using System.Text;

namespace AMapWebservice.Response.Model
{
    /// <summary>
    /// 逆地址编码
    /// http://lbsyun.baidu.com/index.php?title=webapi/guide/webservice-geocoding-abroad
    /// </summary>
    public class ReGeoDetailItem
    {
       

        /// <summary>
        /// 地址;结构化地址信息
        /// </summary>
        public string formatted_address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AddressComponent addressComponent { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, string> pois { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, string> reoads { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, string> roadinters { get; set; }
    }
}
