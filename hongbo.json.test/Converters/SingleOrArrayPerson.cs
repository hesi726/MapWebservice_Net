using hongbo.json.Attributes;
using hongbo.json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace hongbo.json.test.Converters
{
    /// <summary>
    /// 用于测试的 SingleOrArrayPerson 类;
    /// </summary>
    public class SingleOrArrayPerson
    {
        public SingleOrArray<string> Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public SingleOrArray<int> Age { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(CryptIdConverter))]
        public int Id { get; set; }

        [CryptId]
        public int Xid { get; set; }

        [JsonConverter(typeof(TimestampConverter),  "2000-01-01")]
        public DateTime BirthDate { get; set; }

        [JsonConverter(typeof(TimestampConverter))]
        public DateTime? CreateDatetime { get; set; }


    }
}
