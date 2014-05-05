using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApplication1.DAL
{
    public class AccountDAL
    {
        AdventureWorks2012Entities db = new AdventureWorks2012Entities();

        /// <summary>
        /// 校验用户名密码
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool IsAuthenticated(string username, string password)
        {
            return db.Login.Where(c => c.UserName == username && c.Password == password).ToList().Count > 0;
        }
    }
}