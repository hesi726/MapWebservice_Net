using AMap.Request;
using AMap.Request.Models;
using AMap.Response.Model;
using AmapWebService_CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMap.Util
{
    /// <summary>
    /// BaiduMapClient 的扩展类;
    /// </summary>
    public static class AMapClientUtil
    {
        /// <summary>
        /// 根据地址获取高德的地址信息（包含坐标、城市省份地区地址、高德Poi)，注意,本接口将通过网络访问高德服务器;
        /// 注意，只解析一个地址;
        /// </summary>
        /// <param name="client"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public static Geocode GetGeoResult(string address, string city = null)
        {
            var client = AMapConfig.GetClient();
            address = address.Replace("(", "").Replace(")", "").Replace(" ","");
            var geoRequest = new GeoCoderRequest(new GeoCoderModel
            {
                Address = address,
                City = city
            });
            var geoResponse = client.Execute(geoRequest);
            return geoResponse.geocodes.First();
        }
    }
}
