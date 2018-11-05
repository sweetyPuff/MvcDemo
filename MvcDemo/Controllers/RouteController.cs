using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class RouteController : Controller
    {
        public ActionResult Index(string id)
        {
            return View();
        }

        [Route("Test/{id}")]
        public ActionResult Test(string id)
        {
            return View();
        }
    }
}