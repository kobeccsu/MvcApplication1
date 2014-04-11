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
            var temp = "";
            if (filterContext.RouteData.Values["controller"].ToString() != "Account")
            {
                filterContext.Result = new RedirectResult(new UrlHelper(filterContext.RequestContext).Action("Login", "Account"));
            }
        }
    }
}