using System;
using System.Security.Cryptography;
using System.Text;

namespace BaiduMapWebservice.Util
{
    public static class EncryptUtil
    {
        public static string MD5(string password)
        {
            var bytes = Encoding.UTF8.GetBytes(password);
            try
            {
                var md5CryptHandler = new MD5CryptoServiceProvider();
                var hash = md5CryptHandler.ComputeHash(bytes);
                var stringBuilder = new StringBuilder();
                foreach (byte v in hash)
                {
                    stringBuilder.Append(v.ToString("x2"));
                }
                return stringBuilder.ToString();
            }
            catch
            {
                throw;
            }
        }
    }
}
