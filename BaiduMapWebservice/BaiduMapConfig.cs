using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduMapWebservice
{
    /// <summary>
    /// 百度地图的配置类;
    /// </summary>
    public class BaiduMapConfig
    {

        private static List<BaiduMapClient> clientList = new List<BaiduMapClient>();
        static BaiduMapConfig()
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
        public static void AddBaiduMapConfig(string appKey, string secretKey)
        {
            clientList.Add(new BaiduMapClient(appKey, secretKey));
        }
        

        private static int cnt = 0;
        /// <summary>
        /// 获取百度地图客户端;
        /// </summary>
        /// <param name="cnt"></param>
        public static BaiduMapClient GetClient()
        {
            cnt++;
            return clientList[cnt % clientList.Count()];
        }
    }
}
