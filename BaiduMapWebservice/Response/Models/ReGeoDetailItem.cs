using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Response.Models
{
    /// <summary>
    /// 逆地址编码
    /// http://lbsyun.baidu.com/index.php?title=webapi/guide/webservice-geocoding-abroad
    /// </summary>
    public class ReGeoDetailItem
    {
        /// <summary>
        /// 根据经纬度坐标获取地址
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// 地址;结构化地址信息
        /// </summary>
        public string formatted_address { get; set; }

        /// <summary>
        /// 商圈（坐标所在商圈信息，如 "人民大学,中关村,苏州街"。最多返回3个）
        /// </summary>
        public string business { get; set; }

        /// <summary>
        /// addressComponent, 地址组件;
        /// （注意，国外行政区划，字段仅代表层级）
        /// </summary>
        public AddressComponent addressComponent { get; set; }

        /// <summary>
        /// 百度 Poi
        /// </summary>
        public List<Poi> pois { get; set; }

        /// <summary>
        /// Poi地区信息
        /// </summary>
        public  PoiRegion poiRegion { get; set;  }

        /// <summary>
        /// 当前位置结合POI的语义化结果描述。
        /// </summary>
        public string sematic_description { get; set; }


    }
}
