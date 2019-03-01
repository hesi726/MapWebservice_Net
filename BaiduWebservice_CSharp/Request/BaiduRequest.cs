using System;
using System.Collections.Generic;
using BaiduMap.Request.Models;
using BaiduMap.Response;
using BaiduMap.Util;

namespace BaiduMap.Request
{
    public abstract class BaiduRequest<T, S> : IBaiduRequest<T>
        where T: BaiduResponse 
        where S: BaiduModel
    {
        protected readonly S model;
        public string Host { get; set; } = "http://api.map.baidu.com";
        public string Address { get; set; }

        public bool RequiredTimestamp { get; protected set; } = false;

        public BaiduRequest(S model)
        {
            this.model = model;
        }

        public virtual Dictionary<string, string> GetParameters()
        {
            return DictionaryUtil.GetDictionary(model);
        }

    }
}
