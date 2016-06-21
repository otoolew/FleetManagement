using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusinessFlow.Models;
using BusinessFlow.Data;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BusinessFlow.Controllers
{
    public class InventoryController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Equipment()
        {
            return View();
        }
        public IActionResult Part()
        {
            return View();
        }
        public IActionResult Material()
        {
            return View();
        }
    }
}
