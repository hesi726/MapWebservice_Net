using System;
using System.Collections.Generic;
using System.Text;

namespace AMap.Json
{
    /// <summary>
    /// 字符串或者字符串数组
    /// </summary>
    public class StringOrStringArray 
    {
        public StringOrStringArray()
        {

        }

        public StringOrStringArray(string val)
        {
            Value = val;
        }

        public StringOrStringArray(string[] val)
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
        public string Value { get; set; }

        /// <summary>
        /// 数组值;
        /// </summary>
        public string[] ValueArray { get; set; }

        public static implicit operator StringOrStringArray(string val)
        {
            return new StringOrStringArray(val);
        }

        public static implicit operator StringOrStringArray(string[] val)
        {
            return new StringOrStringArray(val);
        }
    }
}
