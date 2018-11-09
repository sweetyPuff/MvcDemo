using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDemo.Models;
using MvcDemo.Models.ViewModel;

namespace MvcDemo.Controllers
{
    public class PassDataController : Controller
    {
        public ActionResult PassDataTest()
        {
            var order = new Order{Id = 10};


            ViewData["Name"] = "Neil";
            ViewData["Order"] = order;


            ViewBag.Name = "Neil";
            ViewBag.Order = order;


            TempData["Name"] = "Neil";
            TempData["Order"] = order;


            var passDataViewModel = new PassDataViewModel { Name = "Neil", Order = order};
            return View(passDataViewModel);
        }


        public ActionResult Index()
        {

            ViewData["Name"] = "Neil";
            ViewBag.Name = "Neil";
            TempData["Name"] = "Neil";
            var passDataViewModel = new PassDataViewModel { Name = "Neil"};

            return RedirectToAction("NewPage", passDataViewModel);
        }


        public ActionResult NewPage(PassDataViewModel viewModel)
        {
            return View(viewModel);
        }
    }
}