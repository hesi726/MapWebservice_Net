using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMap.Json
{
    /// <summary>
    /// 字符串或者字符串数组
    /// </summary>
    /// 定义此标注时，将不会再调用 StringOrStringArrayConvert 中的 CanConvert 方法;
    [JsonConverter(typeof(StringOrStringArrayConvert))]
    public class SingleOrArray<T> 
    {
        //public SingleOrArray()
        //{

        //}

        public SingleOrArray(T val)
        {
            Value = val;
        }

        public SingleOrArray(T[] val)
        {
            ValueArray = val;
        }

        /// <summary>
        /// 是否是数组;
        /// </summary>
        public bool IsArray
        {
            get
            {
                if (ValueArray == null) return false;
                return true;
            }
        }

        /// <summary>
        /// 字符串值;
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// 数组值;
        /// </summary>
        public T[] ValueArray { get; set; }

        /// <summary>
        /// 隐式转换，稀奇的是，如果 T 为字符串，反序列化时不需要任何特殊处理即可调用此函数；
        /// 但如果 T 为 int 类型，反序列化时需要结合 SingleOrStringArrayConvert 才能够使用成功反序列化;
        /// </summary>
        /// <param name="val"></param>

        public static implicit operator SingleOrArray<T>(T val)
        {
            return new SingleOrArray<T>(val);
        }

        //public static implicit operator SingleOrArray<T>(string val)
        //{
        //    return new SingleOrArray<T>((T) Convert.ChangeType(val, typeof(T)));
        //}


        public static implicit operator SingleOrArray<T>(T[] val)
        {
            return new SingleOrArray<T>(val);
        }
    }
}
