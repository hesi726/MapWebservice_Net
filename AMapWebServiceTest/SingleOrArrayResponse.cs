using AMap.Json;
using Mapservice_Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMapWebServiceTest
{
    /// <summary>
    /// 
    /// </summary>
    public class SingleOrArrayResponse : IResponse
    {
        public SingleOrArray<string> Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public SingleOrArray<int> Age { get; set; }

        public string Meta { get; set; }
    }
}
