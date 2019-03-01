using System;
using BaiduMap.Request.Models;
using BaiduMap.Response;

namespace BaiduMap.Request
{
    /// <summary>
    /// 坐标转换查询请求数据
    /// </summary>
    public class CoordTransformRequest : BaiduRequest<CoordTransformResponse, CoordTransfModel>
    {
        public CoordTransformRequest(CoordTransfModel model) : base(model)
        {
            this.Address = "/geoconv/v1/";
        }
    }
}
