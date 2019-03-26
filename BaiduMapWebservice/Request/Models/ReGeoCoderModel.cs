using CoreMapWebservice;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Request.Models
{
    /// <summary>
    /// 逆向地址编码
    /// http://lbsyun.baidu.com/index.php?title=webapi/guide/webservice-geocoding-abroad
    /// </summary>
    public class ReGeoCoderModel : BaiduModel
    {
        /// <summary>
        /// 构造函数;
        /// </summary>
        public ReGeoCoderModel()
        {
            this.radius = 500;
        }

        /// <summary>
        /// 38.76623,116.43213  注意，维度在前，经度在后;
        /// </summary>
        [Required]
        public string location { get; set; }

        /// <summary>
        /// Poi召回半径;
        /// </summary>
        public int radius { get; set; }

        /// <summary>
        /// 是否召回传入坐标周边的poi，0为不召回，1为召回。当值为1时，默认显示周边1000米内的poi。
        /// </summary>
        public int pois { get; set; }
    }
}
