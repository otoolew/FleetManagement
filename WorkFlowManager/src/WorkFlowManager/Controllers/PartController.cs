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
    public class PartController : Controller
    {
        readonly PartDataContext _dataContext;

        public PartController(PartDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            var parts = _dataContext.Parts.OrderByDescending(x => x.Id).ToArray();
            return View(parts);
        }

        [HttpGet]
        public ActionResult Details(long? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(400);
            }
            Part part = _dataContext.Parts.SingleOrDefault(x => x.Id == Id);
            if (part == null)
            {
                return HttpNotFound();
            }
            return View(part);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //public class CreatePartRequest
        //{
        //    public string Serial { get; set; }
        //    public string Name { get; set; }          
        //    public string Brand { get; set; }
        //    public string Model { get; set; }
        //    public string Type { get; set; }
        //    public string Supplier { get; set; }
        //}

        [HttpPost]
        public async Task<IActionResult> Create(Part part)
        {
            if (!ModelState.IsValid)
            {
                return View(part);
            }

            part.Serial = part.Serial;
            part.Name = part.Name;
            part.Brand = part.Brand;
            part.Model = part.Model;
            part.Type = part.Type;
            part.Supplier = part.Supplier;
            _dataContext.Parts.Add(part);

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
            Part part = _dataContext.Parts.SingleOrDefault(x => x.Id == Id);
            if (part == null)
            {
                return HttpNotFound();
            }
            return View(part);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Part part)
        {
            if (!ModelState.IsValid)
            {
                return View(part);
            }

            part.Serial = part.Serial;
            part.Name = part.Name;
            part.Brand = part.Brand;
            part.Model = part.Model;
            part.Type = part.Type;
            part.Supplier = part.Supplier;
            _dataContext.Parts.Update(part);

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
            Part part = _dataContext.Parts.SingleOrDefault(x => x.Id == Id);
            if (part == null)
            {
                return HttpNotFound();
            }
            return View(part);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(long Id)
        {
            Part part = _dataContext.Parts.SingleOrDefault(x => x.Id == Id);
            _dataContext.Parts.Remove(part);
            await _dataContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Part(long Id)
        {
            var db = new PartDataContext();
            var part = db.Parts.SingleOrDefault(x => x.Id == Id);
            return View(part);
        }
    }
}
