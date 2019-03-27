using System;
using System.Collections.Generic;
using System.Text;

namespace hongbo.json.Attributes
{

    /// <summary>
    /// 标注在某一个属性上,表明某一个Id自动需要加密进行传输;
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class CryptIdAttribute : Attribute
    {
        public CryptIdAttribute(): this(null)
        {
        }

        public CryptIdAttribute(Type cryptType)
        {
            this.CryptType = cryptType;
        }

        /// <summary>
        /// 加密的类型;
        /// </summary>
        public Type CryptType { get; private set; }
    }
}
