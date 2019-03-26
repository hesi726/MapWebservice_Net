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