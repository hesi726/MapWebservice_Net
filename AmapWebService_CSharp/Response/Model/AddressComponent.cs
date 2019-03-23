using AMap.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMap.Response.Model
{
    /// <summary>
    /// 地址组件;
    /// </summary>
    public class AddressComponent
    {
        /// <summary>
        /// 地址所在的省份名
        /// </summary>
        public string province { get; set; }


        /// <summary>
        /// 地址所在的城市名
        /// </summary>
        public string city { get; set; }


        /// <summary>
        /// 城市编码例如：010
        /// </summary>
        public string citycode { get; set; }

        /// <summary>
        /// 地址所在的区
        /// </summary>
        public string district { get; set; }

        /// <summary>
        /// 区域编码例如：110101
        /// </summary>
        public string adcode { get; set; }

        /// <summary>
        /// 地址所在的乡镇
        /// </summary>
        public string[] township { get; set; }


        /// <summary>
        /// 街道
        /// </summary>
        public SingleOrArray<string> street { get; set; }

        /// <summary>
        /// 门牌例如：6号
        /// </summary>
        public SingleOrArray<string> number { get; set; }

        /// <summary>
        /// 门牌信息列表
        /// </summary>
        public string[] streetNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, BusinessArea> businessAreas { get; set; }

        /// <summary>
        /// level
        /// </summary>
        public string level { get; set; }

        /// <summary>
        /// "116.480656,39.989677"
        /// </summary>
        public string location { get; set; }

        /// <summary>
        /// 建筑物信息;
        /// </summary>
        public Building building { get; set; }

        /// <summary>
        /// 临近信息;
        /// </summary>
        public Building neighborhood { get; set; }
    }
}
