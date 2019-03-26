using CoreMapWebservice;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMapWebservice.Request.Models
{
    /// <summary>
    /// 地址解析;从地址解析成坐标;
    /// https://lbs.amap.com/api/webservice/guide/api/georegeo
    /// </summary>
    public class GeoCoderModel : AMapModel
    {
        /// <summary>
        /// 规则遵循：国家、省份、城市、区县、城镇、乡村、街道、门牌号码、屋邨、大厦，
        /// 如：北京市朝阳区阜通东大街6号。
        /// 如果需要解析多个地址的话，
        /// 请用"|"进行间隔，并且将 batch 参数设置为 true，最多支持 10 个地址进进行"|"分割形式的请求。
        /// </summary>
        [Required]
        public string Address { get; set; }

        /// <summary>
        /// 可选参数
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 批量查询控制,
        /// </summary>
        public bool? Batch
        {
            get
            {
                if (Address.IndexOf("|") >= 0) return true;
                return null;
            }
        }
      
    }
}
