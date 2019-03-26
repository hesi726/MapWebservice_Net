using BaiduMapWebservice.Request.Models;
using BaiduMapWebservice.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Request
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
