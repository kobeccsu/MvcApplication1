﻿using MvcApplication1.Filters;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new MyAuthFilterAttribute()); // 全局的权限控制
            filters.Add(new HandleErrorAttribute());
            filters.Add(new MyActionFilterAttribute()); // 权限控制
        }
    }
}