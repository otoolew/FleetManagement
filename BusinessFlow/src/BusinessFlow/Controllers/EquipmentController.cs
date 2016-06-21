using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusinessFlow.Models;
using BusinessFlow.Data;


namespace BusinessFlow.Controllers
{
    public class EquipmentController : Controller
    {
        readonly EquipmentDataContext _dataContext;

        public EquipmentController(EquipmentDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            var equipmentList = _dataContext.EquipmentList.OrderByDescending(x => x.Id).ToArray();
            return View(equipmentList);
        }

        [HttpGet]
        public ActionResult Details(long? Id)
        {
            if (Id == null)
            {
                return new BadRequestResult();
            }
            Equipment piece = _dataContext.EquipmentList.SingleOrDefault(x => x.Id == Id);
            if (piece == null)
            {
                return new NotFoundResult();
            }
            return View(piece);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public class CreateEquipmentRequest
        {
            public string Name { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public string Year { get; set; }
            public string Type { get; set; }
        }

        [HttpPost]
        public async Task<IActionResult> Create(Equipment piece)
        {
            if (!ModelState.IsValid)
            {
                return View(piece);
            }
          
            piece.Name = piece.Name;
            piece.Make = piece.Make;
            piece.Model = piece.Model;
            piece.Year = piece.Year;
            piece.Type = piece.Type;

            _dataContext.EquipmentList.Add(piece);

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
            Equipment piece = _dataContext.EquipmentList.SingleOrDefault(x => x.Id == Id);
            if (piece == null)
            {
                return new StatusCodeResult(500);
            }
            return View(piece);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Equipment piece)
        {
            if (!ModelState.IsValid)
            {
                return View(piece);
            }
            
            piece.Name = piece.Name;
            piece.Make = piece.Make;
            piece.Model = piece.Model;
            piece.Year = piece.Year;
            piece.Type = piece.Type;

            _dataContext.EquipmentList.Update(piece);

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
            Equipment piece = _dataContext.EquipmentList.SingleOrDefault(x => x.Id == Id);
            if (piece == null)
            {
                return new StatusCodeResult(500);
            }
            return View(piece);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(long Id)
        {
            Equipment piece = _dataContext.EquipmentList.SingleOrDefault(x => x.Id == Id);
            _dataContext.EquipmentList.Remove(piece);
            await _dataContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Equipment(long Id)
        {
            var db = new EquipmentDataContext();
            var piece = db.EquipmentList.SingleOrDefault(x => x.Id == Id);
            return View(piece);
        }
    }
}
