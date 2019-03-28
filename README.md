# BaiduMapWebservice &amp; AMapWebservice
百度和高德的地图调用接口;

百度地图WEBSERVICE 的 C# 调用接口( 基本上代码复制自 （https://github.com/Seamas/BaiduMapWebApi ）)，
为避开百度地图WEBSERVICE 调用次数限制，支持多个 百度地图 WEBSERVICE 的 appid 

//全局配置百度的 AppId 和 SecretKey,  
BaiduMapConfig.AddBaiduMapConfig("Ar0P3ZtGzAbdDRvacMWUVvvHtjtftoWI", "iLY3xsGGI1SQ7kHjH9TbGAclgv9TI3FF");
 
 // 根据坐标解析地址并获取周围200米之内的POI信息;  
 var client = BaiduMapConfig.GetClient();  
 IPPoint baiduGps = new IPPoint { X = lng, Y = lat };  
 var model = new ReGeoCoderModel   
 {
                location = string.Format("{0},{1}", baiduGps.Y, baiduGps.X),  
                pois = 1,  
                radius = 200  
 };  
 var request = new ReGeoCoderRequest(model);  
 ReGeoCoderResponse result = client.Execute(request);  


 
 高德地图Webservice 的 c# 调用接口; 
 暂时只实现地址解析 和地址逆解析 2个,因为我们公司只用到这2个,   
 //全局配置高德的 AppId 和 SecretKey,    
 AMapConfig.AddAmapConfig("511b21a2f1c05c2f03b2ea6157b95a3b4d");  //amap key is error, please assign your app key  
 var firstGeo = AMapClientUtil.GetGeoResult("方恒国际中心A座", "北京");  