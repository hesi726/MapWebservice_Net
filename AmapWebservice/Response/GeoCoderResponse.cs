using AMapWebservice.Response.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMapWebservice.Response
{
    /// <summary>
    /// 地理编码查询响应数据
    /// </summary>
    public class GeoCoderResponse: AMapListResultResponse<Geocode>
    {
        /// <summary>
        /// 响应;
        /// </summary>
        public List<Geocode> geocodes { get; set; }
    }
}
