using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace hongbo.json.Setting
{
    /// <summary>
    /// hongbo 的 JsonSerializerSettings 类;
    /// 继承自 JsonSerializerSettings,
    /// 必须配合 HongboJsonConvert 才能使用;
    /// </summary>
    public class HongboJsonSerializerSettings : JsonSerializerSettings
    {
        /// <summary>
        /// 在Json序列化时需要忽略的标注类列表;
        /// </summary>
        private List<Type> jsonIgnoreAttributeList = new List<Type>();

        /// <summary>
        /// 添加不需要序列化的标注类,
        /// 类似于 JsonIgnoreAttribute, 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void AddJsonIgnoreAttribute<TAttr>()
            where TAttr : Attribute
        {
            jsonIgnoreAttributeList.Add(typeof(TAttr));
        }
    }
}
