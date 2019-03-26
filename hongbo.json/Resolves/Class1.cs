using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace hongbo.json.Resolves
{
    /// <summary>
    /// 
    /// </summary>
    public class TypeNameResolve : IContractResolver
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public JsonContract ResolveContract(Type type)
        {
            // return new JsonContract(type);
            return null;
        }
    }
}
