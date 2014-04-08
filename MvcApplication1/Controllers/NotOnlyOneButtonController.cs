using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class NotOnlyOneButtonController : Controller
    {
        //
        // GET: /NotOnlyOneButton/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Insert()
        {
            return View("Index");
        }

        [HttpPost]
        public ActionResult Index(string para)
        {
            return View();
        }
    }
}
