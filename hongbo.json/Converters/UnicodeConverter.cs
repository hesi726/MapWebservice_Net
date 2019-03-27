using hongbo.json.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace hongbo.json.Converters
{
    /// <summary>
    /// String Unicode 序列化（输出为Unicode编码字符）
    /// 代码复制自: https://blog.csdn.net/sqqyq/article/details/51059027 
    /// 稍微改动;;
    /// </summary>
    public class EncodingConverter : JsonConverter
    {
        public EncodingConverter(): this(Encoding.Unicode)
        {
        }

        public EncodingConverter(Encoding encoding)
        {
            this.encoding = encoding;
        }

        private Encoding encoding = null;
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var val = reader.Value;
            if (val == null) return null;
            return UnicodeUtil.Decode(val as string);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null) writer.WriteNull();
            else writer.WriteValue(UnicodeUtil.Encode(value.ToString()));
        }

        

        

        

    }
}
