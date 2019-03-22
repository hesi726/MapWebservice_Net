using AMap.Request.Models;
using AMapMap.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMap.Request
{
    /// <summary>
    /// 逆向地理编码查询请求数据
    /// </summary>
    public class ReGeoCoderRequest : AMapRequest<ReGeoCoderResponse, ReGeoCoderModel>
    {
        public ReGeoCoderRequest(ReGeoCoderModel model) : base(model)
        {
            this.Address = "/geocode/geo";
        }
    }
}
