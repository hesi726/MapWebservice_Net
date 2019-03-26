using AMapWebservice.Response;
using AMapWebservice.Response.Model;
using System;
using System.Collections.Generic;
using System.Text;
using AMapWebservice.Request;

namespace AMapWebservice.Response
{
    /// <summary>
    /// 逆地理编码查询响应数据
    /// </summary>
    public class ReGeoCoderResponse: AMapResponse
    {
        /// <summary>
        /// 逆地址的编码解析结果（单个)
        /// <see cref="ReGeoCoderRequest.batch"/> = false 时，返回此结果;
        /// </summary>
        public ReGeoDetailItem regeocode { get; set; }


        /// <summary>
        /// 逆地址的编码解析结果（多个)
        /// <see cref="ReGeoCoderRequest.batch"/> = true 时，返回此结果;
        /// </summary>
        public List<ReGeoDetailItem> regeocodes { get; set; }
    }
}
