using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Response.Models
{
    public class Vehicle
    {
        public int? Type { get; set; }
        public VehicleDetail Detail { get; set; }
    }
}
