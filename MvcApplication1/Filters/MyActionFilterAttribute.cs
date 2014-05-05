using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcApplication1.Filters
{
    public class MyActionFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            string act = filterContext.RouteData.Values["action"].ToString();
            string ctr = filterContext.RouteData.Values["controller"].ToString();
            if (act == "Index" && ctr == "NotOnlyOneButton") // 过滤掉自己，否则会无限循环
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary { { "controller", "Home" }, { "action", "Index" } });
            }
        }
    }
}