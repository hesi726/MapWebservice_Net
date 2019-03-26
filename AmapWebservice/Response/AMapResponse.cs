using CoreMapWebservice;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMapWebservice.Response
{
    public class AMapResponse : AbstractResponse, IAMapResponse
    {
        /// <summary>
        /// 返回结果状态标志, --  返回值为 0 或 1，0 表示请求失败；1 表示请求成功
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string info { get; set; }

        /// <summary>
        /// 信息状态;
        /// </summary>
        public string infocode { get; set; }
    }
}
