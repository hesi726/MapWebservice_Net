using AMapWebservice.Response;
using AMapWebservice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
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

        /// <summary>
        /// 测试地址解析结果的Json反序列化
        /// </summary>
        [TestMethod]
        public void DeserialzeGeoCoderResponse()
        {
            var json = @"{""status"":""1"",""info"":""OK"",""infocode"":""10000"",""count"":""1"",""geocodes"":[{""formatted_address"":""北京市朝阳区方恒国际中心|A座"",""country"":""中国"",""province"":""北京市"",""citycode"":""010"",""city"":""北京市"",""district"":""朝阳区"",""township"":[],""neighborhood"":{""name"":[],""type"":[]},""building"":{""name"":[],""type"":[]},""adcode"":""110105"",""street"":[],""number"":[],""location"":""116.480656,39.989677"",""level"":""门牌号""}]}";
            var firstGeo = client.DeserialzeObject<GeoCoderResponse>(json).geocodes.First();
            Assert.IsTrue(firstGeo.city == "北京市");
            Assert.IsTrue(firstGeo.formatted_address == "北京市朝阳区方恒国际中心|A座");
            Assert.IsTrue(firstGeo.province == "北京市");
            Assert.IsTrue(firstGeo.citycode == "010");
            Assert.IsTrue(firstGeo.district == "朝阳区");
        }

        /// <summary>
        /// 测试坐标逆解析结果的Json反序列化
        /// </summary>
        [TestMethod]
        public void DeserialzeReGeoCoderResponse()
        {
            var json = @"{""status"":""1"",""regeocode"":{""addressComponent"":{""city"":""广州市"",""province"":""广东省"",""adcode"":""440103"",""district"":""荔湾区"",""towncode"":""440103016000"",""streetNumber"":{""number"":""39-41号"",""location"":""113.234829,23.0956758"",""direction"":""西北"",""distance"":""5.13984"",""street"":""花地大道北""},""country"":""中国"",""township"":""花地街道"",""businessAreas"":[{""location"":""113.22920880838318,23.08934754391219"",""name"":""芳村"",""id"":""440103""},{""location"":""113.27621431593793,23.13001418476728"",""name"":""二三路"",""id"":""440104""}],""building"":{""name"":[],""type"":[]},""neighborhood"":{""name"":[],""type"":[]},""citycode"":""020""},""formatted_address"":""广东省广州市荔湾区花地街道花地大道北39-41号华苑商业广场""},""info"":""OK"",""infocode"":""10000""}";
            var firstGeo = client.DeserialzeObject<ReGeoCoderResponse>(json).regeocode;

            json = @"{""status"":""1"",""regeocode"":{""addressComponent"":{""city"":""广州市"",""province"":""广东省"",""adcode"":""440103"",""district"":""荔湾区"",""towncode"":""440103008000"",""streetNumber"":{""number"":""23号"",""location"":""113.244856,23.127685"",""direction"":""东"",""distance"":""27.0603"",""street"":""龙源新一巷""},""country"":""中国"",""township"":""金花街道"",""businessAreas"":[{""location"":""113.24618428070171,23.12686938596491"",""name"":""陈家祠"",""id"":""440103""},{""location"":""113.24390343265311,23.129331138775512"",""name"":""荔湾路"",""id"":""440103""},{""location"":""113.26933427830193,23.12798241037737"",""name"":""岭南"",""id"":""440104""}],""building"":{""name"":[],""type"":[]},""neighborhood"":{""name"":""科润苑公寓"",""type"":""商务住宅;住宅区;住宅小区""},""citycode"":""020""},""formatted_address"":""广东省广州市荔湾区金花街道科润苑公寓新景城中心""},""info"":""OK"",""infocode"":""10000""}";
            firstGeo = client.DeserialzeObject<ReGeoCoderResponse>(json).regeocode;

            json = @"{""status"":""1"",""regeocode"":{""addressComponent"":{""city"":""广州市"",""province"":""广东省"",""adcode"":""440111"",""district"":""白云区"",""towncode"":""440111014000"",""streetNumber"":{""number"":""21号"",""location"":""113.252417,23.2461431"",""direction"":""东南"",""distance"":""10.4054"",""street"":""夏花一路""},""country"":""中国"",""township"":""石井街道"",""businessAreas"":[[]],""building"":{""name"":[],""type"":[]},""neighborhood"":{""name"":[],""type"":[]},""citycode"":""020""},""formatted_address"":""广东省广州市白云区石井街道君和商务大厦""},""info"":""OK"",""infocode"":""10000""}";
            firstGeo = client.DeserialzeObject<ReGeoCoderResponse>(json).regeocode;

        }

        
    }

    
}
