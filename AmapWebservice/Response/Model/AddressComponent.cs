using hongbo.json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMapWebservice.Response.Model
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
        /// 噗通的是，
        /// 在地址解析中，township 返回空数组;
        /// 地址逆解析中，township 返回字符串;
        /// </summary>
        public SingleOrArray<string> township { get; set; }


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
        public StreetNumber streetNumber { get; set; }

        /// <summary>
        /// 噗通,
        /// 有时候是 BusinessArea 数组，例如 [{location: ''}
        /// 有时候是 空数组， 例如解析，113.252417,23.2461431 返回 [[]]
        /// </summary>
        public List<SingleOrArray<BusinessArea>> businessAreas { get; set; }

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
        public Neighborhood neighborhood { get; set; }
    }
}
