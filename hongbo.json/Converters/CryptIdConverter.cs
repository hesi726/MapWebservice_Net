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

namespace hongbo.json.Converters
{
    /// <summary>
    /// CryptIdConverter, 对整数进行加密或者解密传输的类;
    /// </summary>
    public class CryptIdConverter : JsonConverter
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="hashSaltAppenx">使用 hashids 加密时的 Salt 后缀字符串, Salt 字符串将使用 nameof(ClassName)_saltAppenx, 
        /// 例如  Person_Ehay 的形式</param>
        /// <param name="minLen">加密后的字符串的最小长度</param>
        public CryptIdConverter(): this("hongbo.json", 8)
        {
        }


        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="hashSaltAppenx">使用 hashids 加密时的 Salt 后缀字符串, Salt 字符串将使用 nameof(ClassName)_saltAppenx, 
        /// 例如  Person_Ehay 的形式</param>
        /// <param name="minLen">加密后的字符串的最小长度</param>
        public CryptIdConverter(string hashSaltAppenx = "hongbo.json", int minLen = 8)
        {
            this.minLen = minLen;
            this.saltAppenx = hashSaltAppenx;
        }

        private int minLen;
        private string saltAppenx;
        /// <summary>
        /// 能否转换
        /// </summary>
        /// <param name="objectType">对象的类型;</param>
        public override bool CanConvert(Type objectType)
        {
            return true;
        }

       

        /// <summary>
        /// 从字符串转换会 int? 或者 int, 解密成id
        /// 或者如果字符串包含有 逗号，则拆分逗号解密再拼接成字符串传输;
        /// </summary>
        public override object ReadJson(JsonReader reader, Type targetType, object existingValue, JsonSerializer serializer)
        {
            throw new Exception("Unsupported operation"); /*
            if (reader.TokenType == JsonToken.StartArray)  //数组;
            {
                var retVal = serializer.Deserialize(reader, arrayGenericArgumentType);
                if (retVal == null) return null;
                var obj = arrayConstructor.Invoke(new object[] { retVal });
                return obj;
            }
            else
            {
                var retVal = serializer.Deserialize(reader, genericArgumentType);
                if (retVal == null) return null;
                var obj = singleConstructor.Invoke(new object[] { retVal });
                return obj;
            } */
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
