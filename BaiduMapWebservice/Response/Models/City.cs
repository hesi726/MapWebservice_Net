using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Response.Models
{
    public class City
    {
        public string City_Id { get; set; }
        public string City_Name { get; set; }
        public Location location { get; set; }
    }
}
