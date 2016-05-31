using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WorkFlowManager.Models;

namespace WorkFlowManager.Controllers
{
    public class BidController : Controller
    {
        readonly BidDataContext _dataContext;

        public BidController(BidDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            var bids = _dataContext.Bids.OrderByDescending(x => x.Id).ToArray();
            return View(bids);
        }

        [HttpGet]
        public ActionResult Details(long? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(400);
            }
            Bid bid = _dataContext.Bids.SingleOrDefault(x => x.Id == Id);
            if (bid == null)
            {
                return HttpNotFound();
            }
            return View(bid);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public class CreateBidRequest
        {
            public string ECMS { get; set; }
            public string County { get; set; }
            public string Location { get; set; }
            public string BidLetDate { get; set; }
            public string QuoteDate { get; set; }
        }

        [HttpPost]
        public async Task<IActionResult> Create(Bid bid)
        {
            if (!ModelState.IsValid)
            {
                return View(bid);
            }

            bid.ECMS = bid.ECMS;
            bid.County = bid.County;
            bid.Location = bid.Location;
            bid.BidLetDate = bid.BidLetDate;
            bid.QuoteDate = bid.QuoteDate;

            _dataContext.Bids.Add(bid);

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
            Bid bid = _dataContext.Bids.SingleOrDefault(x => x.Id == Id);
            if (bid == null)
            {
                return HttpNotFound();
            }
            return View(bid);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Bid bid)
        {
            if (!ModelState.IsValid)
            {
                return View(bid);
            }

            bid.ECMS = bid.ECMS;
            bid.County = bid.County;
            bid.Location = bid.Location;
            bid.BidLetDate = bid.BidLetDate;
            bid.QuoteDate = bid.QuoteDate;

            _dataContext.Bids.Update(bid);

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
            Bid bid = _dataContext.Bids.SingleOrDefault(x => x.Id == Id);
            if (bid == null)
            {
                return HttpNotFound();
            }
            return View(bid);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(long Id)
        {
            Bid bid = _dataContext.Bids.SingleOrDefault(x => x.Id == Id);
            _dataContext.Bids.Remove(bid);
            await _dataContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Bid(long Id)
        {
            var db = new BidDataContext();
            var bid = db.Bids.SingleOrDefault(x => x.Id == Id);
            return View(bid);
        }
    }
}