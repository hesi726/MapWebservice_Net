using BaiduMapWebservice.Request;
using BaiduMapWebservice.Request.Models;
using BaiduMapWebservice.Response;
using BaiduMapWebservice.Response.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduMapWebservice.Util
{
    /// <summary>
    /// BaiduMapClient 的扩展类;
    /// </summary>
    public static class BaiduMapClientUtil
    {
        /// <summary>
        /// 根据地址获取百度的地址信息（包含坐标、城市省份地区地址、百度Poi)，注意,本接口将通过网络访问百度服务器;
        /// </summary>
        /// <param name="client"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public static ReGeoDetailItem GetAddressInfo(BaiduMapClient client, string address)
        {
            address = address.Replace("(", "").Replace(")", "").Replace(" ","");
            var geoCoderModel = new GeoCoderModel
            {
                Address = address
            };
            var req = new GeoCoderRequest(geoCoderModel);
            var res = client.Execute(req);
            if (res.Result == null || res.Result.Location == null)
            {
                return null; //返回 null;
            }
            return GetAddressInfo(client, res.Result.Location.Lng, res.Result.Location.Lat);
        }

        /// <summary>
        /// 根据坐标解析地址;
        /// </summary>
        /// <param name="client"></param>
        /// <param name="lng"></param>
        /// <param name="lat"></param>
        /// <returns></returns>
        public static ReGeoDetailItem GetAddressInfo(BaiduMapClient client, double? lng, double? lat)
        {
            IPPoint baiduGps = new IPPoint { X = lng, Y = lat };
            var model = new ReGeoCoderModel
            {
                location = string.Format("{0},{1}", baiduGps.Y, baiduGps.X),
                pois = 1,
                radius = 200
            };
            var request = new ReGeoCoderRequest(model);
            ReGeoCoderResponse result = client.Execute(request);
            if (result.Result == null) return null;
            var regeo = result.Result;
            return regeo;
        }

        /// <summary>
        /// 转换高德地理坐标为百度的地图坐标
        /// </summary>
        /// <returns></returns>
        public static IPPoint ConvertFromAmapGps(BaiduMapClient baiduClient, decimal longitude, decimal latitude)
        {
            var model = new CoordTransfModel
            {
                Coords = string.Format("{0},{1}", longitude, latitude),
                From = CoordTransfModel.From_AMAP
            };
            var req = new CoordTransformRequest(model);
            var resp = baiduClient.Execute(req);
            if (resp.Result != null && resp.Result.Count > 0)
                return resp.Result[0];
            return null;
        }
    }
}
