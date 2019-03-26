using Newtonsoft.Json;
using System;
using System.Reflection;

namespace hongbo.json.Converters
{
    /// <summary>
    /// StringOrStringArrayConvert ：  
    /// 对 SingleOrArray 属性进行 Json转换的类;
    /// </summary>
    public class SingleOrArrayConverter : JsonConverter
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="allowNull"></param>
        /// <param name="cryptType"></param>
        public SingleOrArrayConverter()
        {
        }
        /// <summary>
        /// SingleOrArray<> 泛型的类型参数; 
        /// </summary>
        Type genericArgumentType = null;
        /// <summary>
        /// SingleOrArray<> 泛型类型参数的数组类型;
        /// </summary>
        Type arrayGenericArgumentType = null;
        /// <summary>
        /// SingleOrArray 泛型的类型的构造函数;
        /// </summary>
        ConstructorInfo arrayConstructor = null;
        /// <summary>
        /// SingleOrArray 泛型的类型的构造函数;
        /// </summary>
        ConstructorInfo singleConstructor = null;
        /// <summary>
        /// 能否转换
        /// </summary>
        /// <param name="objectType">对象的类型;</param>
        public override bool CanConvert(Type objectType)
        {
            if (!objectType.IsGenericType) return false;
            if (objectType.GetGenericArguments().Length != 1) return false;
            var result = objectType.Name.StartsWith(SingleOrArrayTypeName);
            if (!result) return false;
            IntiateGenericTypeInfo(objectType);

            return result;
        }

        public static string SingleOrArrayTypeName = typeof(SingleOrArray<>).Name;
        /// <summary>
        /// 初始化泛型信息;
        /// </summary>
        /// <param name="objectType"></param>
        private void IntiateGenericTypeInfo(Type objectType)
        {
            genericArgumentType = objectType.GetGenericArguments()[0];
            arrayGenericArgumentType = Array.CreateInstance(genericArgumentType, 0).GetType();
            var genericObjectType = typeof(SingleOrArray<>);
            var xtype = genericObjectType.MakeGenericType(genericArgumentType);
            arrayConstructor = xtype.GetConstructor(new Type[] { arrayGenericArgumentType });
            singleConstructor = xtype.GetConstructor(new Type[] { genericArgumentType });
        }

        /// <summary>
        /// 从字符串转换会 int? 或者 int, 解密成id
        /// 或者如果字符串包含有 逗号，则拆分逗号解密再拼接成字符串传输;
        /// </summary>
        public override object ReadJson(JsonReader reader, Type targetType, object existingValue, JsonSerializer serializer)
        {
            if (this.genericArgumentType == null) IntiateGenericTypeInfo(targetType);
            if (reader.TokenType == JsonToken.StartArray)  //数组;
            {
                var retVal = serializer.Deserialize(reader, arrayGenericArgumentType);
                if (retVal == null) return null;
                var obj = arrayConstructor.Invoke(new object[] { retVal });
                return obj;
            }
            else
            {
                var retVal = serializer.Deserialize(reader, genericArgumentType);
                if (retVal == null) return null;
                var obj = singleConstructor.Invoke(new object[] { retVal });
                return obj;
            }           
        }
        

        /// <summary>
        /// 从字符串转换会 int? 或者 int, 加密成id
        /// </summary>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new Exception("Unsupported operation");
        }
    }
}
