using System;
using System.Collections.Generic;
using System.Text;

namespace AMapWebservice.Response.Model
{
    /// <summary>
    /// 地址解码后的结果;
    /// </summary>
    public class Geocode : AddressComponent
    {
        /// <summary>
        /// 省份＋城市＋区县＋城镇＋乡村＋街道＋门牌号码
        /// </summary>
        public string formatted_address { get; set; }

       


    }
}
