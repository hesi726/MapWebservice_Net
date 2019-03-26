using BaiduMapWebservice.Response.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Response
{
    public class RidePlanResponse: BaiduSingleResponse<RidePlanItem>
    {
        public CopyRightInfo Info { get; set; }
        public int? Type { get; set; }
    }

}
