using AMap.Json;
using AMap.Request;
using AMap.Request.Models;
using AMap.Response;
using AMap.Util;
using AmapWebService_CSharp;
using Mapservice_Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AMapWebServiceTest
{
    [TestClass]
    public class AmapClientTest
    {
        AMapClient client = null;

        [TestInitialize]
        public void TestIntialize()
        {
            client = AMapConfig.GetClient();
            if (client == null)
            {
                AMapConfig.AddAmapConfig("1b21a2f1c05c2f03b2ea6157b95a3b4d");
            }
            client = AMapConfig.GetClient();
        }

        [TestCleanup]
        public void TestCleanup()
        {

        }

        [TestMethod]
        public void DeserialzeObject()
        {
            var json = @"{""Name"": ""daiwei""}";
            var singleOrArray = client.DeserialzeObject<SingleOrArrayTest>(json);
            Assert.IsTrue(singleOrArray.Name.Value == "daiwei");

            json = @"{""Name"": ""daiwei"",""Age"": 20}";
            singleOrArray = client.DeserialzeObject<SingleOrArrayTest>(json);
            Assert.IsTrue(singleOrArray.Name.Value == "daiwei");
            Assert.IsTrue(singleOrArray.Age.Value == 20);

            json = @"{""Name"": null}";
            singleOrArray = client.DeserialzeObject<SingleOrArrayTest>(json);
            Assert.IsTrue(singleOrArray.Name == null);
            Assert.IsTrue(singleOrArray.Age == null);

            json = @"{""Name"": [""daiwei"",""Zhao""], ""Age"": [18,20]}";
            singleOrArray = client.DeserialzeObject<SingleOrArrayTest>(json);
            Assert.IsTrue(singleOrArray.Name.ValueArray[0] == "daiwei");
            Assert.IsTrue(singleOrArray.Name.ValueArray[1] == "Zhao");

            Assert.IsTrue(singleOrArray.Age.ValueArray[0] == 18);
            Assert.IsTrue(singleOrArray.Age.ValueArray[1] == 20);

            json = @"{""status"":""1"",""info"":""OK"",""infocode"":""10000"",""count"":""1"",""geocodes"":[{""formatted_address"":""北京市朝阳区方恒国际中心|A座"",""country"":""中国"",""province"":""北京市"",""citycode"":""010"",""city"":""北京市"",""district"":""朝阳区"",""township"":[],""neighborhood"":{""name"":[],""type"":[]},""building"":{""name"":[],""type"":[]},""adcode"":""110105"",""street"":[],""number"":[],""location"":""116.480656,39.989677"",""level"":""门牌号""}]}";
            var firstGeo = client.DeserialzeObject<GeoCoderResponse>(json).geocodes.First();
            Assert.IsTrue(firstGeo.city == "北京市");
            Assert.IsTrue(firstGeo.formatted_address == "北京市朝阳区方恒国际中心|A座");
            Assert.IsTrue(firstGeo.province == "北京市");
            Assert.IsTrue(firstGeo.citycode == "010");
            Assert.IsTrue(firstGeo.district == "朝阳区");

        }
    }

    public class SingleOrArrayTest : IResponse
    {
        public SingleOrArray<string> Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public SingleOrArray<int> Age { get; set; }

        public string Meta { get; set; }
    }
}
