using System;
using System.Text;
using System.Web;
using System.Linq;
using System.Collections.Generic;

namespace BaiduMapWebservice.Util
{
    public static class UrlUtil
    {
        /// <summary>
        /// 对字符串编码使用  UrlEncode 编码，
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Encode(string str)
        {
            str = HttpUtility.UrlEncode(str);
            byte[] buf = Encoding.ASCII.GetBytes(str);
            for (int i = 0; i < buf.Length; i++)
                if (buf[i] == '%')
                {
                    if (buf[i + 1] >= 'a') buf[i + 1] -= 32;  //%后面的2个字符串转换成大写形式
                    if (buf[i + 2] >= 'a') buf[i + 2] -= 32;
                    i += 2;
                }
            var result = Encoding.ASCII.GetString(buf);
            return result;
        }        

        public static string BuildQuery(IDictionary<string, string> dictionary)
        {
            var list = dictionary.Select(item => $"{item.Key}={Encode(item.Value)}");
            return String.Join("&", list);
        }       
    }
}
