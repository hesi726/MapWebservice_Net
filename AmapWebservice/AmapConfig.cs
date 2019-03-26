using System;
using System.Collections.Generic;
using System.Text;

namespace AMapWebservice
{
    /// <summary>
    /// 高德地图的配置类;
    /// </summary>
    public class AMapConfig
    {
        private static List<AMapClient> clientList = new List<AMapClient>();
        static AMapConfig()
        {
            //AddBaiduMapConfig("key1", "appsecret1"); //戴伟的
            //AddBaiduMapConfig("key2","appsecret1");  //小董
            //AddBaiduMapConfig("key3","appsecret3");  // 温怡婷
        }

        /// <summary>
        /// 添加百度地图应用的 key 和 secretKey
        /// </summary>
        /// <param name="appKey"></param>
        /// <param name="secretKey"></param>
        public static void AddAmapConfig(string appKey)
        {
            clientList.Add(new AMapClient(appKey));
        }


        private static int cnt = 0;
        /// <summary>
        /// 获取百度地图客户端;
        /// </summary>
        /// <param name="cnt"></param>
        public static AMapClient GetClient()
        {
            if (clientList == null || clientList.Count==0) return null;
            cnt++;
            return clientList[cnt % clientList.Count];
        }
    }
}
