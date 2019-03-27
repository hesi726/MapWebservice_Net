using hongbo.json.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Text;

namespace hongbo.json.test.Converters
{
    [TestClass]
    public class UnicodeConverterTest
    {
        [TestMethod]
        public void DeserialzeSingleOrArrayObject()
        {
            var chair = "习大大";
            var person = new UnicodeConverterPerson { BirthDate = chair, CreateDatetime = null };
            var personJson = JsonConvert.SerializeObject(person);
            var dperson = JsonConvert.DeserializeObject<UnicodeConverterPerson>(personJson);
            Assert.IsTrue(dperson.BirthDate == chair && dperson.CreateDatetime == null);

            var create = "蓝雷军蚂蚁奥阿斯顿噶杀手GDP企鹅调剖去问他区韦尔特";
            person.CreateDatetime = create;
            personJson = JsonConvert.SerializeObject(person);
            dperson = JsonConvert.DeserializeObject<UnicodeConverterPerson>(personJson);
            Assert.IsTrue(dperson.BirthDate == chair && dperson.CreateDatetime == create);
        }
    }

    /// <summary>
    /// 用于测试的 TimestampConverterPerson 类;
    /// </summary>
    public class UnicodeConverterPerson
    {
       
        [JsonConverter(typeof(EncodingConverter))]
        public string BirthDate { get; set; }

        [JsonConverter(typeof(EncodingConverter))]
        public string CreateDatetime { get; set; }


    }
}
