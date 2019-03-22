using System;
using System.Collections.Generic;
using BaiduMap.Request.Models;
using BaiduMap.Response;
using BaiduMap.Util;
using Mapservice_Core;

namespace BaiduMap.Request
{
    public abstract class BaiduRequest<TResponse, TRequestModel> : AbstractRequest<TResponse, TRequestModel>, 
        IBaiduRequest<TResponse>
        where TResponse: BaiduResponse 
        where TRequestModel: BaiduModel
    {
        public BaiduRequest(): base()
        {
            this.Host = "http://api.map.baidu.com";
        }
        public BaiduRequest(TRequestModel model): this()
        {
            this.model = model;
        }

       
       

        public bool RequiredTimestamp { get; protected set; } = false;

        

      

    }
}
