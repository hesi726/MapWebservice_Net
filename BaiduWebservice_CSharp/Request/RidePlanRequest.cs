using BaiduMap.Request.Models;
using BaiduMap.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMap.Request
{
    public class RidePlanRequest : BaiduRequest<RidePlanResponse, RidePlanModel>
    {
        public RidePlanRequest(RidePlanModel model): base(model)
        {
            this.Address = "/direction/v2/riding";

            this.RequiredTimestamp = true;
        }
    }
}
