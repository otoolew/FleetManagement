using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace WorkFlowManager.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Fleet()
        {
            return View();
        }
        public IActionResult Part()
        {
            return View();
        }
        public IActionResult Business()
        {
            return View();
        }
        public IActionResult Job()
        {
            return View();
        }
        public IActionResult Support()
        {
            ViewData["Message"] = "Please contact us if you need any technical support.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
