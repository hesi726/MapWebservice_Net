using AMapWebservice.Request.Models;
using AMapWebservice.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMapWebservice.Request
{
    /// <summary>
    /// 地理编码查询请求数据,根据地址解析坐标;
    /// https://lbs.amap.com/api/webservice/guide/api/georegeo
    /// </summary>
    public class GeoCoderRequest : AMapRequest<GeoCoderResponse, GeoCoderModel>
    {
        public GeoCoderRequest(GeoCoderModel model) : base(model)
        {
            this.Address = "/geocode/geo";
        }
    }
}
