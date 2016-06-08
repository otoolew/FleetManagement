using System.Linq;
using Microsoft.AspNet.Mvc;
using WorkFlowManager.DAL;

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