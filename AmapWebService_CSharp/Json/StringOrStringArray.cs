using System;
using System.Collections.Generic;
using System.Text;

namespace AMap.Json
{
    /// <summary>
    /// 字符串或者字符串数组
    /// </summary>
    public class SingleOrArray<T> 
    {
        public SingleOrArray()
        {

        }

        public SingleOrArray(T val)
        {
            Value = val;
        }

        public SingleOrArray(T[] val)
        {
            ValueArray = val;
        }
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

        public static implicit operator SingleOrArray<T>(T val)
        {
            return new SingleOrArray<T>(val);
        }

        public static implicit operator SingleOrArray<T>(T[] val)
        {
            return new SingleOrArray<T>(val);
        }
    }
}
