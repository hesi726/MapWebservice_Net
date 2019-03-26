 高德地图Webservice 的 c# 调用接口; 
 为避开高德地图WEBSERVICE 调用次数限制，支持多个 百度地图 WEBSERVICE 的 appid 
 暂时只实现地址解析 和地址逆解析 2个，因为我们公司只用到这2个；

 //全局配置高德的 AppId 和 SecretKey,  
 AMapConfig.AddAmapConfig("511b21a2f1c05c2f03b2ea6157b95a3b4d");  //amap key is error, please assign your app key;
 AMapConfig.AddAmapConfig("511b21a2f1c05c2f03b2ea6157b95a3b4d");  //amap key is error, please assign your app key;
 AMapConfig.AddAmapConfig("511b21a2f1c05c2f03b2ea6157b95a3b4d");  //amap key is error, please assign your app key;
 AMapConfig.AddAmapConfig("511b21a2f1c05c2f03b2ea6157b95a3b4d");  //amap key is error, please assign your app key;
 将轮询使用上面的 Key;
  var firstGeo = AMapClientUtil.GetGeoResult("方恒国际中心A座", "北京");

 顺便说一下，高德的地址解析 和 地址逆解析 返回的结果很不规范，
 例如:
 AddressComponent 中的  businessAreas 字段，
 有时候是 

 "businessAreas":{"location":"113.22920880838318,23.08934754391219","name":"芳村","id":"440103"}
 或者这样，
 "businessAreas":[{"location":"113.22920880838318,23.08934754391219","name":"芳村","id":"440103"},{"location":"113.27621431593793,23.13001418476728","name":"二三路","id":"440104"}]
 或者这样:
 "businessAreas": [[]]
 
