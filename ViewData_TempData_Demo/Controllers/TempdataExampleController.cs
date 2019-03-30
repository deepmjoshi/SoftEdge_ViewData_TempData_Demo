using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewData_TempData_Demo.Controllers
{
    public class TempdataExampleController : Controller
    {
        // GET: TempdataExample
        public ActionResult Index()
        {
            TempData["message1"] = "This is message1";
            TempData["message2"] = "This is message2";
            TempData["message3"] = "This is message3";
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult Index3()
        {
            return View();
        }
    }
}