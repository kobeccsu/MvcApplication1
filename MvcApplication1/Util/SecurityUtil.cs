using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace MvcApplication1.Util
{
    public class SecurityUtil
    {
        /// <summary>
        /// 根据输入参数返回其 md5 值
        /// </summary>
        /// <param name="originalPassword"></param>
        /// <returns></returns>
        public static string GetMD5Password(string originalPassword)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            Byte[] originalBytes = ASCIIEncoding.Default.GetBytes(originalPassword);
            Byte[] encodedBytes = md5.ComputeHash(originalBytes);

            return BitConverter.ToString(encodedBytes).Replace("-", "");

        }
    }
}