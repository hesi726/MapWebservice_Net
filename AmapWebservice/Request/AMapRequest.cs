using AMapWebservice.Request.Models;
using AMapWebservice.Response;
using CoreMapWebservice;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMapWebservice.Request
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
