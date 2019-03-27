using hongbo.json.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace hongbo.json.test.Converters
{
    [TestClass]
    public class TimestampConvertTest
    {
        [TestMethod]
        public void DeserialzeSingleOrArrayObject()
        {
            var person = new TimestampConverterPerson { BirthDate = DateTime.Parse("2020-01-01") };
            var personJson = JsonConvert.SerializeObject(person);
            var dperson = JsonConvert.DeserializeObject<TimestampConverterPerson>(personJson);
            Assert.IsTrue(dperson.BirthDate == DateTime.Parse("2020-01-01") && !dperson.CreateDatetime.HasValue);

            var create = DateTime.Parse("2001-12-31 12:58:58.123");
            person.CreateDatetime = create;
            personJson = JsonConvert.SerializeObject(person);
            dperson = JsonConvert.DeserializeObject<TimestampConverterPerson>(personJson);
            Assert.IsTrue(dperson.BirthDate == DateTime.Parse("2020-01-01") && dperson.CreateDatetime.Value == create);
        }
    }

    /// <summary>
    /// 用于测试的 TimestampConverterPerson 类;
    /// </summary>
    public class TimestampConverterPerson
    {
       
        [JsonConverter(typeof(TimestampConverter), "2000-01-01")]
        public DateTime BirthDate { get; set; }

        [JsonConverter(typeof(TimestampConverter), "1980-01-01")]
        public DateTime? CreateDatetime { get; set; }


    }
}
