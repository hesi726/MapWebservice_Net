using System;
using System.Collections.Generic;
using System.Text;

namespace AMapWebservice.Response.Model
{
    /// <summary>
    /// 门牌信息列表
    /// </summary>
    public class StreetNumber
    {
        /// <summary>
        /// 街道名称,例如：中关村北二条
        /// </summary>
        public string street { get; set; }

        /// <summary>
        /// 门牌号例如：3号
        /// </summary>
        public string number { get; set; }
        /// <summary>
        /// 坐标点, 经纬度坐标点：经度，纬度
        /// </summary>
        public string location { get; set; }
        /// <summary>
        /// 方向，坐标点所处街道方位
        /// </summary>
        public string direction { get; set; }
        /// <summary>
        /// 门牌地址到请求坐标的距离,单位：米
        /// </summary>
        public string distance { get; set; }


    }
}
