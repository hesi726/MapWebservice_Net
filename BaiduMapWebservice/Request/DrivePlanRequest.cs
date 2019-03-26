using BaiduMapWebservice.Request.Models;
using BaiduMapWebservice.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Request
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
