using System;
using System.Collections.Generic;
using System.Text;

namespace AMap.Response.Model
{
    /// <summary>
    /// 建筑物信息或者临近地址信息;
    /// </summary>
    public class Building
    {
        public string[] name { get; set; }

        public string[] type { get; set; }
    }
}
