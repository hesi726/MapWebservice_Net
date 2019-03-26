using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaiduMapWebservice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaiduMapWebservice.Response.Models;
using BaiduMapWebservice.Util;

namespace BaiduMapWebservice.Tests
{
    [TestClass()]
    public class BaiduMapClientUtilTests
    {
        BaiduMapClient client;

        /// <summary>
        /// 
        /// </summary>
        [TestInitialize]
        public void TestInitiate()
        {
            // the follow key is only for test;
            BaiduMapConfig.AddBaiduMapConfig("Ar0P3ZtGzAbdDRvacMWUVvvHtjtftoWI", "iLY3xsGGI1SQ7kHjH9TbGAclgv9TI3FF");
            client = BaiduMapConfig.GetClient();
        }
        /// <summary>
        /// 温怡婷
        /// </summary>
         

        [TestMethod()]
        public void BaiduMapClientUtil_GetPoi()
        {
            ReGeoDetailItem result;
            
            result = BaiduMapClientUtil.GetAddressInfo(client, "广东省广州市天河区潭村路凯旋西街7号之一");
            Assert.IsTrue(result != null);
            Assert.IsTrue(result.addressComponent.province == "广东省");
            Assert.IsTrue(result.addressComponent.city == "广州市");
            Assert.IsTrue(result.addressComponent.district == "天河区");
            Assert.IsTrue(result.Location.Lng.HasValue);
            Assert.IsTrue(result.Location.Lat.HasValue);
            Assert.IsTrue(result.business != null);
            Assert.IsTrue(result.pois.Count > 0);

            result = BaiduMapClientUtil.GetAddressInfo(client, "广东省广州市海珠区新港东路磨碟沙大道118号珠江啤酒厂文化创意园琶醍B区103");
            Assert.IsTrue(result != null);
            Assert.IsTrue(result.addressComponent.province == "广东省");
            Assert.IsTrue(result.addressComponent.city == "广州市");
            Assert.IsTrue(result.addressComponent.district == "海珠区");
            Assert.IsTrue(result.Location.Lng.HasValue);
            Assert.IsTrue(result.Location.Lat.HasValue);
            Assert.IsTrue(result.business != null);
            Assert.IsTrue(result.pois.Count > 0);

            result = BaiduMapClientUtil.GetAddressInfo(client, "北京市海淀区上地十街10号");
            Assert.IsTrue(result != null);
            Assert.IsTrue(result.addressComponent.city == "北京市");
            Assert.IsTrue(result.addressComponent.province == "北京市");
            Assert.IsTrue(result.addressComponent.district == "海淀区");
            Assert.IsTrue(result.business != null);
            Assert.IsTrue(result.Location.Lng.HasValue);
            Assert.IsTrue(result.Location.Lat.HasValue);
            Assert.IsTrue(result.pois.Count > 0);
            Assert.IsTrue(result.pois[0].name == "百度大厦");

            result = BaiduMapClientUtil.GetAddressInfo(client, "广东省广州市天河区珠江东路6号(周大福金融中心)K11购物中心-1710");
            Assert.IsTrue(result != null);
            Assert.IsTrue(result.addressComponent.province == "广东省");
            Assert.IsTrue(result.addressComponent.city == "广州市");
            Assert.IsTrue(result.addressComponent.district == "天河区");
            Assert.IsTrue(result.Location.Lng.HasValue);
            Assert.IsTrue(result.business != null);
            Assert.IsTrue(result.Location.Lat.HasValue);
            Assert.IsTrue(result.pois.Count > 0);


            result = BaiduMapClientUtil.GetAddressInfo(client, "广东省广州市天河区珠江新城金穗路62号侨鑫国际2204");
            Assert.IsTrue(result != null);
            Assert.IsTrue(result.addressComponent.province == "广东省");
            Assert.IsTrue(result.addressComponent.city == "广州市");
            Assert.IsTrue(result.addressComponent.district == "天河区");
            Assert.IsTrue(result.Location.Lng.HasValue);
            Assert.IsTrue(result.Location.Lat.HasValue);
            Assert.IsTrue(result.business != null);
            Assert.IsTrue(result.pois.Count > 0);
            Assert.IsTrue(result.pois[0].name == "侨鑫国际"); 

            result = BaiduMapClientUtil.GetAddressInfo(client, "广东省广州市天河区棠东东路5号远洋创意园B101/B118");
            Assert.IsTrue(result != null);
            Assert.IsTrue(result.addressComponent.province == "广东省");
            Assert.IsTrue(result.addressComponent.city == "广州市");
            Assert.IsTrue(result.addressComponent.district == "天河区");
            Assert.IsTrue(result.Location.Lng.HasValue);
            Assert.IsTrue(result.business != null);
            Assert.IsTrue(result.Location.Lat.HasValue);
            Assert.IsTrue(result.pois.Count > 0);

            result = BaiduMapClientUtil.GetAddressInfo(client, "广东省广州市天河区临江大道8号珠江商学院3楼");
            Assert.IsTrue(result != null);
            Assert.IsTrue(result.addressComponent.province == "广东省");
            Assert.IsTrue(result.addressComponent.city == "广州市");
            Assert.IsTrue(result.addressComponent.district == "天河区");
            Assert.IsTrue(result.business != null);
            Assert.IsTrue(result.Location.Lng.HasValue);
            Assert.IsTrue(result.Location.Lat.HasValue);
            Assert.IsTrue(result.pois.Count > 0);

           
            
        }
    }
}