using BaiduMap.Request.Models;
using BaiduMap.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMap.Request
{
    public class DrivePlanRequest : BaiduRequest<DrivePlanResponse, DrivePlanModel>
    {
        public DrivePlanRequest(DrivePlanModel model): base(model)
        {
            this.Address = "/direction/v2/driving";

            this.RequiredTimestamp = true;
        }
    }
}
