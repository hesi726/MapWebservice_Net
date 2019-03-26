using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Response.Models
{
    public class Taxi
    {
        public int? Distance { get; set; }
        public int? Duration { get; set; }
        public string Remark { get; set; }

        public List<TaxiDetail> Detail { get; set; }
    }
}
