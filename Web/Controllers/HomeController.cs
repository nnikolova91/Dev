using System;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("index")]
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }

        [Route("info")]
        public ActionResult Info()
        {
            ViewBag.Title = "Info Page";
            return View(new PCInfo() { LogicalProcessors = Environment.ProcessorCount, Time = DateTime.Now });
        }
    }
}