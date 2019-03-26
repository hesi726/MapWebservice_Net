#hongbo.json
实际开发过程中使用到的一些 Json 属性和转换类;


hongbo.json.Converters.CryptIdConverter -- 当某一个整数需要加密传输时,应该使用此字段对其进行标注;则进行 Json 序列化以及反Json序列化时，将加密传输;  
										   系统使用 hashids 对其进行加密和解密;  
										   注意，对于数组，和 hashids 对数组加密后组合为字符串不同，加密后还是数组，以便 js 客户端能够访问其任意一个数组中的项;  
hongbo.json.Converters.SingleOrArray --  当属性可能是单项或者数组项时，应该使用此类对属性进行定义（具体看单元测试的例子);  
hongbo.json.Converters.SingleOrArrayConverter -- 用于 SingleOrArray 属性的 JsonConverter 类;  
hongbo.json.Converters.TimestampConverter   -- 日期到时间戳的格式转换;