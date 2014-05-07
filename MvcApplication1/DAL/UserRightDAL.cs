using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.DAL
{
    public class UserRightDAL
    {
        AdventureWorks2012Entities db = new AdventureWorks2012Entities();

        /// <summary>
        /// 获取相对路径如：/UserRight/Index
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public List<string> GetControllPath(string username)
        {
            return db.UserRight.Where(user => user.username == username).Select(user => user.controller).ToList();
        }
    }
}