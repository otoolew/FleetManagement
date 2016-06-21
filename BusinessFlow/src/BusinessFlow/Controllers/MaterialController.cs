using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusinessFlow.Models;
using BusinessFlow.Data;

namespace BusinessFlow.Controllers
{
    public class MaterialController : Controller
    {
        readonly MaterialDataContext _dataContext;

        public MaterialController(MaterialDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            var materials = _dataContext.Materials.OrderByDescending(x => x.Id).ToArray();
            return View(materials);
        }

        [HttpGet]
        public ActionResult Details(long? Id)
        {
            if (Id == null)
            {
                return new BadRequestResult();
            }
            Material material = _dataContext.Materials.SingleOrDefault(x => x.Id == Id);
            if (material == null)
            {
                return new StatusCodeResult(500);
            }
            return View(material);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public class CreateMaterialRequest
        {
            public string Description { get; set; }
            public string Price { get; set; }
            public string Quantity { get; set; }
        }

        [HttpPost]
        public async Task<IActionResult> Create(Material material)
        {
            if (!ModelState.IsValid)
            {
                return View(material);
            }

            material.Description = material.Description;
            material.Price = material.Price;
            material.Quantity = material.Quantity;

            _dataContext.Materials.Add(material);

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
            Material material = _dataContext.Materials.SingleOrDefault(x => x.Id == Id);
            if (material == null)
            {
                return new StatusCodeResult(500);
            }
            return View(material);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Material material)
        {
            if (!ModelState.IsValid)
            {
                return View(material);
            }

            material.Description = material.Description;
            material.Price = material.Price;
            material.Quantity = material.Quantity;

            _dataContext.Materials.Update(material);

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
            Material material = _dataContext.Materials.SingleOrDefault(x => x.Id == Id);
            if (material == null)
            {
                return new StatusCodeResult(500);
            }
            return View(material);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(long Id)
        {
            Material material = _dataContext.Materials.SingleOrDefault(x => x.Id == Id);
            _dataContext.Materials.Remove(material);
            await _dataContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Material(long Id)
        {
            var db = new MaterialDataContext();
            var material = db.Materials.SingleOrDefault(x => x.Id == Id);
            return View(material);
        }
    }
}
