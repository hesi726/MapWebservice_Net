using BaiduMapWebservice.Request.Models;
using BaiduMapWebservice.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Request
{
    public class IPLocationRequest : BaiduRequest<IPLocationResponse, IPModel>
    {
        public IPLocationRequest(IPModel model) : base(model)
        {
            this.Address = "/location/ip";
        }
    }
}
