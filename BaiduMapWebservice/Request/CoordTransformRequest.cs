using System;
using BaiduMapWebservice.Request.Models;
using BaiduMapWebservice.Response;

namespace BaiduMapWebservice.Request
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
