using AMap.Request.Models;
using AMap.Response;
using Mapservice_Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMap.Request
{
    /// <summary>
    /// 请求类;
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AMapRequest<TResponse, TRequestModel> : AbstractRequest<TResponse, TRequestModel>
        where TRequestModel: AMapModel
        where TResponse : IAMapResponse
    {
        public AMapRequest()
        {
            this.Host = "https://restapi.amap.com/v3";
        }

        public AMapRequest(TRequestModel model) : this()
        {
            this.model = model;
        }
    }
}
