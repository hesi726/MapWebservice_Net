using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace hongbo.json.Converters
{
    /// <summary>
    /// 单项或者数组项,
    /// 高德地图中，经常会有此类稀奇的结果存在;
    /// </summary>
    /// 定义此标注时，将不会再调用 StringOrStringArrayConvert 中的 CanConvert 方法;
    /// 表示使用 SingleOrArrayConverter 进行 Json 的转换;
    [JsonConverter(typeof(SingleOrArrayConverter))]
    public class SingleOrArray<T> 
    {
        /// <summary>
        /// 空构造函数;
        /// </summary>
        public SingleOrArray()
        {

        }
        /// <summary>
        /// 单项构造函数
        /// </summary>
        /// <param name="val"></param>
        public SingleOrArray(T val)
        {
            Value = val;
        }

        /// <summary>
        /// 数组项构造函数
        /// </summary>
        /// <param name="val"></param>
        public SingleOrArray(T[] val)
        {
            ValueArray = val;
        }

        /// <summary>
        /// 是否是数组项，
        /// 当全部未指定时，返回 null;
        /// 当指定了数组项时，返回 true;
        /// 否则，返回 false;
        /// </summary>
        public bool? IsArray
        {
            get
            {
                if (ValueArray == null) return false;
                return true;
            }
        }

        /// <summary>
        /// 单项值;
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// 数组项值;
        /// </summary>
        public T[] ValueArray { get; set; }

        /// <summary>
        /// 隐式转换，
        /// </summary>
        /// <param name="val"></param>

        public static implicit operator SingleOrArray<T>(T val)
        {
            return new SingleOrArray<T>(val);
        }

        /// <summary>
        /// 隐式转换
        /// </summary>
        public static implicit operator SingleOrArray<T>(T[] val)
        {
            return new SingleOrArray<T>(val);
        }
    }
}
