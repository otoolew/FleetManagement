using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusinessFlow.Models;
using BusinessFlow.Data;

namespace BusinessFlow.Controllers
{
    public class JobController : Controller
    {
        readonly JobDataContext _dataContext;

        public JobController(JobDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            var jobs = _dataContext.Jobs.OrderByDescending(x => x.Id).ToArray();
            return View(jobs);
        }

        [HttpGet]
        public ActionResult Details(long? Id)
        {
            if (Id == null)
            {
                return new BadRequestResult();
            }
            Job job = _dataContext.Jobs.SingleOrDefault(x => x.Id == Id);
            if (job == null)
            {
                return new StatusCodeResult(500);
            }
            return View(job);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //public class CreateJobRequest
        //{
        //    public string ECMS { get; set; }
        //    public string Number { get; set; }
        //    public string Description { get; set; }
        //    public string Quantity { get; set; }
        //    public string Price { get; set; }
        //    public string Amount { get; set; }
        //}

        [HttpPost]
        public async Task<IActionResult> Create(Job job)
        {
            if (!ModelState.IsValid)
            {
                return View(job);
            }
            job.ECMS = job.ECMS;
            job.Contractor = job.Contractor;
            job.County = job.County;
            job.Location = job.Location;
            job.BidLetDate = job.BidLetDate;
            job.QuoteDate = job.QuoteDate;

            _dataContext.Jobs.Add(job);

            await _dataContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(long? Id)
        {
            if (Id == null)
            {
                return new BadRequestResult();
            }
            Job job = _dataContext.Jobs.SingleOrDefault(x => x.Id == Id);
            if (job == null)
            {
                return new StatusCodeResult(500);
            }
            return View(job);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Job job)
        {
            if (!ModelState.IsValid)
            {
                return View(job);
            }
            job.ECMS = job.ECMS;
            job.Contractor = job.Contractor;
            job.County = job.County;
            job.Location = job.Location;
            job.BidLetDate = job.BidLetDate;
            job.QuoteDate = job.QuoteDate;

            _dataContext.Jobs.Update(job);

            await _dataContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(long? Id)
        {
            if (Id == null)
            {
                return new BadRequestResult();
            }
            Job job = _dataContext.Jobs.SingleOrDefault(x => x.Id == Id);
            if (job == null)
            {
                return new StatusCodeResult(500);
            }
            return View(job);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(long Id)
        {
            Job job = _dataContext.Jobs.SingleOrDefault(x => x.Id == Id);
            _dataContext.Jobs.Remove(job);
            await _dataContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Job(long Id)
        {
            var db = new JobDataContext();
            var job = db.Jobs.SingleOrDefault(x => x.Id == Id);
            return View(job);
        }
    }
}

