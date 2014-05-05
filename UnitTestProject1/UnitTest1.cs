using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// 测试用户名密码
        /// </summary>
        [TestMethod]
        public void TestMd5()
        {
            Assert.AreEqual(MvcApplication1.Util.SecurityUtil.GetMD5Password("7758258"), "272E7B02A23578284113B15BA99BA770");
        }
    }
}
