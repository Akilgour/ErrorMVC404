using _404.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _404.Controllers
{
    public class ErrorController : Controller
    {
        // GET: ErrorController
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Error404 Error404)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
