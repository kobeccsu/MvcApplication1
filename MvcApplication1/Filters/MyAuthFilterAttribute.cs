using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;
using System.Web.Mvc;
using System.Web.Routing;


namespace MvcApplication1.Filters
{
    public class MyAuthFilterAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //base.OnAuthorization(filterContext);
            //var temp = "";
            
            // 暂时注释，后续做好了所有权限的控制，就放开
            //if (filterContext.RouteData.Values["controller"].ToString() != "Account") // 排除自己，否则会无限循环
            //{
            //    filterContext.Result = new RedirectResult(new UrlHelper(filterContext.RequestContext).Action("Login", "Account"));
            //}
        }
    }
}