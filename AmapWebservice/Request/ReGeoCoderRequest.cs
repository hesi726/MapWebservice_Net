using AMapWebservice.Request.Models;
using AMapWebservice.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMapWebservice.Request
{
    /// <summary>
    /// 逆向地理编码查询请求数据(根据坐标解析地址信息）
    /// https://lbs.amap.com/api/webservice/guide/api/georegeo
    /// </summary>
    public class ReGeoCoderRequest : AMapRequest<ReGeoCoderResponse, ReGeoCoderModel>
    {
        public ReGeoCoderRequest(ReGeoCoderModel model) : base(model)
        {
            this.Address = "/geocode/regeo";
        }
    }
}
