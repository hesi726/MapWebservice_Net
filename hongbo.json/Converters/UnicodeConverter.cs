using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace hongbo.json.Converters
{
    /// <summary>
    /// String Unicode 序列化（输出为Unicode编码字符）
    /// 代码复制自: https://blog.csdn.net/sqqyq/article/details/51059027 
    /// 无任何修改;
    /// </summary>
    public class UnicodeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return reader.Value;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(ToUnicode(value.ToString()));
        }

        public static string ToUnicode(string str)
        {
            byte[] bts = Encoding.Unicode.GetBytes(str);
            string r = "";
            for (int i = 0; i < bts.Length; i += 2)
            {
                r += "\\u" + bts[i + 1].ToString("X").PadLeft(2, '0') + bts[i].ToString("X").PadLeft(2, '0');
            }
            return r;
        }
    }
}
