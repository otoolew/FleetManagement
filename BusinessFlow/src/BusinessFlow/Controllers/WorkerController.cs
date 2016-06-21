using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusinessFlow.Models;
using BusinessFlow.Data;

namespace BusinessFlow.Controllers
{
    public class WorkerController : Controller
    {
        readonly WorkerDataContext _dataContext;
        
        public WorkerController(WorkerDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            var workers = _dataContext.Workers.OrderByDescending(x => x.Id).ToArray();
            return View(workers);
        }

        [HttpGet]
        public ActionResult Details(long? Id)
        {
            if (Id == null)
            {
                return new BadRequestResult();
            }
            Worker worker = _dataContext.Workers.SingleOrDefault(x => x.Id == Id);
            if (worker == null)
            {
                return new StatusCodeResult(500);
            }
            return View(worker);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public class CreatePartRequest
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string JobTitle { get; set; }
            public string HourlyRate { get; set; }
            public string License { get; set; }
        }

        [HttpPost]
        public async Task<IActionResult> Create(Worker worker)
        {
            if (!ModelState.IsValid)
            {
                return View(worker);
            }

            worker.FirstName = worker.FirstName;
            worker.LastName = worker.LastName;
            worker.JobTitle = worker.JobTitle;
            worker.HourlyRate = worker.HourlyRate;
            worker.License = worker.License;

            _dataContext.Workers.Add(worker);

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
            Worker worker = _dataContext.Workers.SingleOrDefault(x => x.Id == Id);
            if (worker == null)
            {
                return new StatusCodeResult(500);
            }
            return View(worker);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Worker worker)
        {
            if (!ModelState.IsValid)
            {
                return View(worker);
            }

            worker.FirstName = worker.FirstName;
            worker.LastName = worker.LastName;
            worker.JobTitle = worker.JobTitle;
            worker.HourlyRate = worker.HourlyRate;
            worker.License = worker.License;

            _dataContext.Workers.Update(worker);

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
            Worker worker = _dataContext.Workers.SingleOrDefault(x => x.Id == Id);
            if (worker == null)
            {
                return new StatusCodeResult(500);
            }
            return View(worker);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(long Id)
        {
            Worker worker = _dataContext.Workers.SingleOrDefault(x => x.Id == Id);
            _dataContext.Workers.Remove(worker);
            await _dataContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Worker(long Id)
        {
            var db = new WorkerDataContext();
            var worker = db.Workers.SingleOrDefault(x => x.Id == Id);
            return View(worker);
        }
    }
}
