using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WorkFlowManager.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkFlowManager.Controllers
{
    public class VehicleController : Controller
    {

        readonly VehicleDataContext _dataContext;

        public VehicleController(VehicleDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public class CreateVehicleRequest
        {
            public string VIN { get; set; }
            public string Name { get; set; }
            public string Year { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public string Type { get; set; }
            public string License { get; set; }
        }

        [HttpPost]
        public async Task<IActionResult> Create(Vehicle vehicle)
        {
   
            if (!ModelState.IsValid)
            {
                return View(vehicle);
            }

            vehicle.VIN = vehicle.VIN;
            vehicle.Name = vehicle.Name;
            vehicle.Year = vehicle.Year;
            vehicle.Make = vehicle.Make;
            vehicle.Model = vehicle.Model;
            vehicle.Type = vehicle.Type;
            vehicle.License = vehicle.License;



            _dataContext.Vehicles.Add(vehicle);
            await _dataContext.SaveChangesAsync();

            return RedirectToAction("Vehicle", new { id = vehicle.Id });
        }

        public IActionResult Vehicle(long Id)
        {
            var db = new VehicleDataContext();
            var vehicle = db.Vehicles.SingleOrDefault(x => x.Id == Id);
            return View(vehicle);
        }
    }
}
