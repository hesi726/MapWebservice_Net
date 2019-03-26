using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace hongbo.json.Utility
{
    /// <summary>
    /// HongboJsonConverta,基本上就是调用 JsonConvert的一些方法;
    /// </summary>
    public static class HongboJsonConverta
    {
        /// <summary>
        /// 序列话对象;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string SerializeObject<T>(T obj)
        {
            JsonSerializerSettings setting = new JsonSerializerSettings
            {
                 // TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.
            };
            return JsonConvert.SerializeObject(obj, setting);
        }
    }
}
