using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication1;
using MvcApplication1.Util;
using System.Collections.Generic;
using MvcApplication1.DAL;

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

        /// <summary>
        /// 测试用户名密码
        /// </summary>
        [TestMethod]
        public void GetAllControll()
        {
            ControllerUtil util = new ControllerUtil();
            List<string> temp = util.GetControllerNames();
        }

        [TestMethod]
        public void TestGetPath()
        {
            UserRightDAL dal = new UserRightDAL();
            string username = "zhoulei";
            List<string> temp = dal.GetControllPath(username);
            //temp.Substring(0,)
        }
    }
}
