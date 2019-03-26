using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduMapWebservice.Response.Models
{
    /// <summary>
    /// PoiRegion
    /// </summary>
    public class PoiRegion
    {
        /// <summary>
        /// 请求中的坐标与所归属区域面的相对位置关系
        /// </summary>
        public string direction_desc { get; set; }

        /// <summary>
        /// 归属区域面名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 归属区域面类型
        /// </summary>
        public string tag { get; set; }
    }
}
