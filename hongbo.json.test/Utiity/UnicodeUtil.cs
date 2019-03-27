using hongbo.json.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace hongbo.json.test.Utility
{
    /// <summary>
    /// Unicode 的编码和解码类;
    /// </summary>
    [TestClass]
    public class UnicodeUtilTest
    {
        

        /// <summary>
        /// 解码;
        /// https://blog.csdn.net/zanychou/article/details/46726785
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [TestMethod]
        public void Test()
        {
            string content = @"Unicode 的编码和解码类;";
            var cnt = UnicodeUtil.Encode(content);
            var dcnt = UnicodeUtil.Decode(cnt);
            Assert.IsTrue(dcnt == content);
        }

       

    }
}
