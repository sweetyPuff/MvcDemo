using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class RouteController : Controller
    {
        // GET: Route
        public ActionResult Index( string id, string name)
        {
            return View();
        }
    }
}