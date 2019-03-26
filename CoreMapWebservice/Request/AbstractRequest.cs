using System;
using System.Collections.Generic;
using System.Text;

namespace CoreMapWebservice
{
    /// <summary>
    /// 抽象的请求类;
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractRequest <TResponse, TModel> : IRequest<TResponse>
        where TResponse : IResponse
    {
        public AbstractRequest()
        {
            this.RequiredTimestamp = false;
        }
        /// <summary>
        /// 主机名称
        /// </summary>
        public string Host { get; protected set; }
        /// <summary>
        /// 请求的Route
        /// </summary>
        public string Address { get; protected set; }

        public bool RequiredTimestamp { get; protected set; }

        /// <summary>
        /// 模型类;
        /// </summary>
        protected  TModel model { get; set; }

        /// <summary>
        /// 给定 Model 的属性和值;
        /// </summary>
        /// <returns></returns>
        public virtual Dictionary<string, string> GetParameters()
        {
            var result = DictionaryUtil.GetDictionary(model);
            if (RequiredTimestamp)
            {
                // 用户未设置timestamp时自动增加，若已经设置timestamp，则使用用户设置的值
                if (!result.ContainsKey("timestamp"))
                {
                    result.Add("timestamp", DateTime.Now.ToTimestamp().ToString());
                }
            }
            return result;
        }
    }
}
