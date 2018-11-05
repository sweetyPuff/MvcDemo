using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class RouteController : Controller
    {
        // GET: Route
        public ActionResult Index(string id)
        {
            return View();
        }

        public ActionResult Test(string id)
        {
            return View();
        }
    }
}