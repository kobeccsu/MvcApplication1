using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
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
            AdventureWorks2012Entities db = new AdventureWorks2012Entities();
            var contextObject = db as Object;
            var contextType = contextObject.GetType();
            var properties = contextType.GetProperties();

            ObjectContext objContext = ((IObjectContextAdapter)db).ObjectContext;
            MetadataWorkspace workspace = objContext.MetadataWorkspace;

            IEnumerable<SelectListItem> items = properties.Where(p => workspace.GetItems<EntityType>(DataSpace.CSpace)
                .Any(e => e.Name == p.Name)).Select(c => new SelectListItem
                   { Value = c.Name, Text = c.Name });
            ViewData["tables"] = items;
            
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
