using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WorkFlowManager.Models;

namespace WWLinePainting.Controllers
{
    public class FleetController : Controller
    {
        private readonly VehicleDataContext _db;

        public FleetController(VehicleDataContext db)
        {
            _db = db;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var posts = _db.Vehicles.OrderByDescending(x => x.Id).ToArray();
            return View(posts);
        }

    }
}
