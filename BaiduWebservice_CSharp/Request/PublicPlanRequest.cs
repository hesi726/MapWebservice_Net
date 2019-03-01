using BaiduMap.Request.Models;
using BaiduMap.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMap.Request
{
    public class PublicPlanRequest : BaiduRequest<PublicPlanResponse, PublicPlanModel>
    {
        public PublicPlanRequest(PublicPlanModel model) : base(model)
        {
            this.Address = "/direction/v2/transit";

            this.RequiredTimestamp = true;
        }

    }
}
