using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WorkFlowManager.Models;
using Microsoft.Data.Entity;
using WorkFlowManager.DAL;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkFlowManager.Controllers
{
    public class ReportController : Controller
    {
        readonly ReportDataContext _dataContext;

        public ReportController(ReportDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            var reports = _dataContext.Reports.OrderByDescending(x => x.Id).ToArray();
            return View(reports);
        }

        [HttpGet]
        public ActionResult Details(long? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(400);
            }
            Report report = _dataContext.Reports.SingleOrDefault(x => x.Id == Id);
            if (report == null)
            {
                return HttpNotFound();
            }
            return View(report);
        }

        [HttpGet]
        public IActionResult Create(long Id)
        {
            var report = new Report();
            report.Id = Id;
            return View(report);
        }

        //public class CreateReportRequest
        //{
        //    public string Serial { get; set; }
        //    public string Name { get; set; }
        //    public string Brand { get; set; }
        //    public string Model { get; set; }
        //    public string Type { get; set; }
        //    public string Supplier { get; set; }
        //}

        [HttpPost]
        public async Task<IActionResult> Create(Report report)
        {
            if (!ModelState.IsValid)
            {
                return View(report);
            }

            report.ReportDate = report.ReportDate;
            report.VehicleID = report.VehicleID;
            report.Comment = report.Comment;

            _dataContext.Reports.Add(report);

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
            Report report = _dataContext.Reports.SingleOrDefault(x => x.Id == Id);
            if (report == null)
            {
                return HttpNotFound();
            }
            return View(report);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Report report)
        {
            if (!ModelState.IsValid)
            {
                return View(report);
            }

            report.ReportDate = report.ReportDate;
            report.VehicleID = report.VehicleID;
            report.Comment = report.Comment;
            _dataContext.Reports.Update(report);

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
            Report report = _dataContext.Reports.SingleOrDefault(x => x.Id == Id);
            if (report == null)
            {
                return HttpNotFound();
            }
            return View(report);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(long Id)
        {
            Report report = _dataContext.Reports.SingleOrDefault(x => x.Id == Id);
            _dataContext.Reports.Remove(report);
            await _dataContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Report(long Id)
        {
            var db = new ReportDataContext();
            var report = db.Reports.SingleOrDefault(x => x.Id == Id);
            return View(report);
        }
    }
}
