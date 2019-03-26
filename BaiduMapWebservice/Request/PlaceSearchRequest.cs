using System;
using System.Collections.Generic;
using BaiduMapWebservice.Request.Models;
using BaiduMapWebservice.Response.Place;
using BaiduMapWebservice.Util;

namespace BaiduMapWebservice.Request
{
    /// <summary>
    /// 地点区域检索请求数据
    /// </summary>
    public class PlaceSearchRequest<T> : BaiduRequest<PlaceSearchResponse, T> where T : PlaceModel
    {
        public PlaceSearchRequest(T placeModel) : base(placeModel)
        {
            this.Address = "/place/v2/search";
        }
    }
}
