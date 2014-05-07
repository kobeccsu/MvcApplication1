using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Util
{
    public class ControllerUtil
    {
        //获取某一个程序集下所有的类
        private static List<Type> GetSubClasses<T>()
        {
            return Assembly.GetCallingAssembly().GetTypes().Where(type => type.IsSubclassOf(typeof(T))).ToList();
        }

        private static List<MethodInfo> GetSubMethods(Type t)
        {
            return t.GetMethods().Where(m => m.ReturnType == typeof(ActionResult) && m.IsPublic == true).ToList();
        }

        public List<string> GetControllerNames()
        {
            List<string> controllerNames = new List<string>();
            foreach (var t in GetSubClasses<Controller>())
            {
                //controllerNames.Add(t.Name); //控制controller 貌似没有什么意义
                List<MethodInfo> mfCollection = GetSubMethods(t);
                mfCollection.ForEach(method => controllerNames.Add(t.Name + "---" + method.Name + (method.IsDefined(typeof(HttpPostAttribute)) ? "---HttpPost" : "")));
            }
            return controllerNames;
        }
    }
}