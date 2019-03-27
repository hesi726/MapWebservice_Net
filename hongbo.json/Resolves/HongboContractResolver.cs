using hongbo.json.Attributes;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;

namespace hongbo.json.Resolves
{
    ///// <summary>
    ///// hongbo 的 ContractResolver
    ///// </summary>
    //public class HongboContractResolver :  DefaultContractResolver
    //{
    //    /// <summary>
    //    /// 在Json序列化时需要忽略的标注类列表;
    //    /// </summary>
    //    private List<Type> jsonIgnoreAttributeList = new List<Type>();

    //    /// <summary>
    //    /// 添加不需要序列化的标注类,
    //    /// 类似于 JsonIgnoreAttribute, 
    //    /// </summary>
    //    /// <typeparam name="T"></typeparam>
    //    public void AddJsonIgnoreAttribute<TAttr>()
    //        where TAttr : Attribute
    //    {
    //        jsonIgnoreAttributeList.Add(typeof(TAttr));
    //    }

    //    /// <summary>
    //    /// 需要忽略的 Property
    //    /// </summary>
    //    [ThreadStatic]
    //    PropertyInfo[] ignoreProperty;

    //    /// <summary>
    //    /// 带有 CryptIdAttribute 标注的 Property
    //    /// </summary>
    //    [ThreadStatic]
    //    (PropertyInfo Property, CryptIdAttribute Attribute)[] cryptIdPropertyTupleList;

    //    ///// <summary>
    //    ///// 带有 CryptIdAttribute 标注的 Property
    //    ///// </summary>
    //    //[ThreadStatic]
    //    //Tuple<PropertyInfo, CombineAndSplitAttribute>[] combineAndSplitPropertyTupleList;

    //    public static Type CryptIdAttributeType = typeof(CryptIdAttribute);
    //    /// <summary>
    //    /// Json序列化时，将传入 type, 以解决数据协议; 
    //    /// 此处查询所有包含有 TypeSciptIgnoreType 标注 的属性出来;
    //    /// </summary>
    //    /// <param name="type"></param>
    //    /// <returns></returns>
    //    public override JsonContract ResolveContract(Type type)
    //    {
    //        cryptIdPropertyTupleList = type.GetProperties()
    //            .Select(a => new { Prop = a, Attr = a.GetCustomAttributes(CryptIdAttributeType, true).FirstOrDefault() as CryptIdAttribute })
    //            .Where(b => b.Attr != null)
    //            .Select(c => (c.Prop, c.Attr))
    //            .ToArray();
    //        cryptIdPropertyTupleList.Where(a => a.Item2.CryptType == null).AsParallel().ForAll((item) =>
    //        {
    //            var propertyName = item.Property.Name;
    //            var foreignKey = type.GetProperty(). TypeUtil.GetFirstPropertyWithAttribute<ForeignKeyAttribute>(type,  (foreign) => foreign.Name == item.Item1.Name);
    //            if (foreignKey.Attr != null)
    //            {
    //                item.Item2.CryptType = foreignKey.Property.PropertyType;
    //            }
    //        });
    //        var firstNullCryptid = cryptIdPropertyTupleList.FirstOrDefault(a => a.Item2.CryptType == null);
    //        if (firstNullCryptid != null)
    //        {
    //            throw new Exception(string.Format("{0}--{1} 指定 CryptIdAttribyte 属性，但未指定 CryptType参数 且无法从外键中推算出此参数",
    //                type.Name, firstNullCryptid.Item1.Name));
    //        }

    //        combineAndSplitPropertyTupleList = type.GetProperties()
    //             .Select(a => new { Prop = a, Attr = a.GetCustomAttributes(CombineAndSplitAttributeType, true).FirstOrDefault() as CombineAndSplitAttribute })
    //             .Where(b => b.Attr != null)
    //             .Select(c => Tuple.Create(c.Prop, c.Attr))
    //             .ToArray();

    //        ignoreProperty = type.GetProperties().Where(a => a.GetCustomAttributes(TypeSciptIgnoreType, true).Length > 0).ToArray();
    //        var result = base.ResolveContract(type);

    //        return result;
    //    }
    //}
}
