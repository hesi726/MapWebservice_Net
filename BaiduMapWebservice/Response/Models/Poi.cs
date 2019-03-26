using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduMapWebservice.Response.Models
{
    /// <summary>
    /// 周边poi信息;
    /// </summary>
    public class Poi
    {
        /// <summary>
        /// 地址信息
        /// </summary>
        public string addr { get; set; }

        /// <summary>
        /// 和当前坐标点的方向
        /// </summary>
        public string direction { get; set; }

        /// <summary>
        /// 和当前坐标点的方向
        /// </summary>
        public int distance { get; set; }

        /// <summary>
        /// poi类型，如’美食;中餐厅’。tag与poiType字段均为poi类型，建议使用tag字段，信息更详细。
        /// poi详细类别
        /// </summary>
        public string tag { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public int? tel { get; set; }

        /// <summary>
        /// poi唯一标识
        /// </summary>
        public string uid { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        public string zip { get; set; }

        /// <summary>
        /// poi名称
        /// </summary>
        public string name { get; set; }
    }
}
