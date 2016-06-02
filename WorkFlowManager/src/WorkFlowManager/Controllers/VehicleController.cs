using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WorkFlowManager.Models;
using Microsoft.Data.Entity;
using WorkFlowManager.DAL;


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
            var vehicles = _dataContext.Vehicles.OrderByDescending(x => x.Id).ToArray();
            return View(vehicles);
        }

        [HttpGet]
        public ActionResult Details(long? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(400);
            }
            Vehicle vehicle = _dataContext.Vehicles.SingleOrDefault(x => x.Id == Id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
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

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(long? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(400);
            }
            Vehicle vehicle = _dataContext.Vehicles.SingleOrDefault(x => x.Id == Id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Vehicle vehicle)
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

            _dataContext.Vehicles.Update(vehicle);

            await _dataContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(long? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(400);
            }
            Vehicle vehicle = _dataContext.Vehicles.SingleOrDefault(x => x.Id == Id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(long Id)
        {
            Vehicle vehicle = _dataContext.Vehicles.SingleOrDefault(x => x.Id == Id);
            _dataContext.Vehicles.Remove(vehicle);
            await _dataContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Vehicle(long Id)
        {
            var db = new VehicleDataContext();
            var vehicle = db.Vehicles.SingleOrDefault(x => x.Id == Id);
            return View(vehicle);
        }
    }
}
