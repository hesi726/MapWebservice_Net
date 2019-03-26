using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace hongbo.json.Converters
{
    /// <summary>
    /// Newtonsoft.Json序列化扩展特性
    /// <para>DateTime序列化（输出为时间戳,使用 Ticks）</para>
    /// 复制自： https://blog.csdn.net/sqqyq/article/details/51059027     
    /// 有修改; 
    /// 允许为 null 的日期; 时间戳使用 Ticks;
    /// 允许指定开始日期;
    /// </summary>
    public class TimestampConverter : JsonConverter
    {
        public TimestampConverter(): this("1970-01-01")
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        public TimestampConverter(string begin)
        {
            this.begin = DateTime.Parse(begin);
        }

        private DateTime begin;

        /// <summary>
        /// 日期能够转换为时间戳;
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime) || objectType == typeof(DateTime?);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null; //
            return ConvertIntDateTime(Int64.Parse(reader.Value.ToString()));
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null) writer.WriteNull(); //为null时写入null值;
            writer.WriteValue(ConvertDateTimeInt((DateTime)value));
        }

        private  DateTime ConvertIntDateTime(long aSeconds)
        {
            return begin.AddTicks(aSeconds);
        }

        private  long ConvertDateTimeInt(DateTime aDT)
        {
            return (aDT - begin).Ticks;
        }
    }
 }
