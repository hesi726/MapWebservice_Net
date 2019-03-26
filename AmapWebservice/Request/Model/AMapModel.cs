using System;

namespace AMapWebservice.Request.Models
{
    /// <summary>
    /// 基本的请求类，只有一个属性， Output=json (默认使用 json 方式输出请求;
    /// </summary>
    public abstract class AMapModel
    {
        /// <summary>
        /// 可选输入内容包括：JSON，XML。设置 JSON 返回结果数据将会以JSON结构构成；如果设置 XML 返回结果数据将以 XML 结构构成。
        /// 服务器默认为 json,
        /// </summary>
        public string Output { get; set; } = "json";
    }
}
