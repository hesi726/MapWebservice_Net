using BaiduMap.Request.Models;
using BaiduMap.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMap.Request
{
    public class IPLocationRequest : BaiduRequest<IPLocationResponse, IPModel>
    {
        public IPLocationRequest(IPModel model) : base(model)
        {
            this.Address = "/location/ip";
        }
    }
}
