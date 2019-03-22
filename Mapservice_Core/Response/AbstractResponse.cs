using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mapservice_Core
{
    public class AbstractResponse : IResponse
    {
        [JsonIgnore]
        public string Meta { get; set; }
    }
}
