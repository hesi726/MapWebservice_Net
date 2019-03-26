using AMapWebservice.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMapWebServiceTest
{
    /// <summary>
    /// 
    /// </summary>
    public class SingleOrArrayResponse 
    {
        public SingleOrArray<string> Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public SingleOrArray<int> Age { get; set; }

        public string Meta { get; set; }
    }
}
