using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Linq;

namespace hongbo.json.test.Converters
{
    [TestClass]
    public class SingleOrArrayJsonConvertTest
    {
        [TestMethod]
        public void DeserialzeSingleOrArrayObject()
        {
            var json = @"{""Name"": ""daiwei""}";
            var singleOrArray = JsonConvert.DeserializeObject<SingleOrArrayPerson>(json);
            Assert.IsTrue(singleOrArray.Name.Value == "daiwei");

            json = @"{""Name"": ""daiwei"",""Age"": 20}";
            singleOrArray = JsonConvert.DeserializeObject<SingleOrArrayPerson>(json);
            Assert.IsTrue(singleOrArray.Name.Value == "daiwei");
            Assert.IsTrue(singleOrArray.Age.Value == 20);

            json = @"{""Name"": null}";
            singleOrArray = JsonConvert.DeserializeObject<SingleOrArrayPerson>(json);
            Assert.IsTrue(singleOrArray.Name == null);
            Assert.IsTrue(singleOrArray.Age == null);

            json = @"{""Name"": [""daiwei"",""Zhao""], ""Age"": [18,20]}";
            singleOrArray = JsonConvert.DeserializeObject<SingleOrArrayPerson>(json);
            Assert.IsTrue(singleOrArray.Name.ValueArray[0] == "daiwei");
            Assert.IsTrue(singleOrArray.Name.ValueArray[1] == "Zhao");

            Assert.IsTrue(singleOrArray.Age.ValueArray[0] == 18);
            Assert.IsTrue(singleOrArray.Age.ValueArray[1] == 20);
        }
    }

    
}
