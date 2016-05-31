using System.Linq;
using Microsoft.AspNet.Mvc;

namespace WorkFlowManager.Controllers
{
    public class BusinessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Bid()
        {
            return View();
        }
        public IActionResult Part()
        {
            return View();
        }
    }      
}