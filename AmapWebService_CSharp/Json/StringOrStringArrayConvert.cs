using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AMap.Json
{
    /// <summary>
    /// StringOrStringArrayConvert ：  可能为字符串 或者 字符串数组 的类;
    /// </summary>
    public class StringOrStringArrayConvert : JsonConverter
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="allowNull"></param>
        /// <param name="cryptType"></param>
        public StringOrStringArrayConvert()
        {
        }

        Type genericArgumentType = null;
        Type arrayGenericArgumentType = null;
        ConstructorInfo constructor = null;

        /// <summary>
        /// 能否转换
        /// </summary>
        /// <param name="objectType">对象的类型;</param>
        public override bool CanConvert(Type objectType)
        {            
            var result = objectType == typeof(SingleOrArray<>);
            genericArgumentType = objectType.GetGenericArguments()[0];
            arrayGenericArgumentType = Array.CreateInstance(genericArgumentType, 0).GetType(); 
            var genericObjectType = typeof(SingleOrArray<>);
            var xtype = genericObjectType.MakeGenericType(genericArgumentType);
            constructor = xtype.GetConstructor(new Type[] { });
            return result;
        }

        /// <summary>
        /// 从字符串转换会 int? 或者 int, 解密成id
        /// 或者如果字符串包含有 逗号，则拆分逗号解密再拼接成字符串传输;
        /// </summary>
        public override object ReadJson(JsonReader reader, Type targetType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartArray)
            {
                var retVal = serializer.Deserialize(reader, arrayGenericArgumentType);
                return new SingleOrArray(retVal);
            }
            else
            {
                var retVal = serializer.Deserialize(reader, genericArgumentType);
                return new SingleOrArray
            }
            return null;


            /*var val = reader.Value;
            if (val == null) return null;
            var value = val.ToString();
            if (value.StartsWith("[")) 
            {
                return new StringOrStringArray(val as string[]);
            }
            else
            {
                return new StringOrStringArray(val as string);
            }
            */
        }
        

        /// <summary>
        /// 从字符串转换会 int? 或者 int, 加密成id
        /// </summary>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new Exception("Unsupported operation");
        }
    }
}
