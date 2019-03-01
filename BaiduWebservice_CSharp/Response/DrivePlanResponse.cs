using BaiduMap.Response.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMap.Response
{
    public class DrivePlanResponse: BaiduSingleResponse<DrivePlanItem>
    {
        public string Type { get; set; }
    }
}
