using MvcApplication1.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class UserRightController : Controller
    {
        //
        // GET: /UserRight/

        public ActionResult Index()
        {
            ControllerUtil util = new ControllerUtil();
            ViewBag.Data = util.GetControllerNames();
            return View();
        }

    }
}
