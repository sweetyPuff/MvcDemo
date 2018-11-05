using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    [RoutePrefix("Booking")]
    public class BookController : Controller
    {

        [Route]
        public ActionResult Index()
        {
            return View();
        }

        [Route("In")]
        public ActionResult Insert()
        {
            return View();
        }
    }
}