using hongbo.json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMapWebservice.Response.Model
{
    /// <summary>
    /// 楼信息列表
    /// </summary>
    public class Building
    {
        /// <summary>
        /// 建筑名称,例如：北京大学
        /// 地址解析中返回空数组，
        /// 地址逆解析中返回字符串或者数组;
        /// </summary>
        public SingleOrArray<string> name { get; set; }

        /// <summary>
        /// 类型，例如：科教文化服务;学校;高等院校
        /// 地址解析中返回空数组，
        /// 地址逆解析中返回字符串或者数组;
        /// </summary>
        public SingleOrArray<string> type { get; set; }
    }
}
