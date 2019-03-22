using AMap.Request;
using AMap.Request.Models;
using AMap.Response;
using AMap.Util;
using AmapWebService_CSharp;
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
            var json = @"{""status"":""1"",""info"":""OK"",""infocode"":""10000"",""count"":""1"",""geocodes"":[{""formatted_address"":""北京市朝阳区方恒国际中心|A座"",""country"":""中国"",""province"":""北京市"",""citycode"":""010"",""city"":""北京市"",""district"":""朝阳区"",""township"":[],""neighborhood"":{""name"":[],""type"":[]},""building"":{""name"":[],""type"":[]},""adcode"":""110105"",""street"":[],""number"":[],""location"":""116.480656,39.989677"",""level"":""门牌号""}]}";
            var result = client.DeserialzeObject<GeoCoderResponse>(json);
            

        }
    }
}
