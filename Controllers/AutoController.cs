using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using automobile_database_system.Models;

namespace automobile_database_system.Controllers
{
    public class AutoController : Controller
    {
        public VehicleDatabaseContext _context;
        public AutoController(VehicleDatabaseContext context)
        {
            _context = context;
        }


        // GET: AutoController
        public ActionResult Index()
        {
            ViewBag.Controller = "User";
            ViewBag.Action = "Index";

            var autos = _context.Autos.ToList();
            return View(autos);
        }

        // GET: AutoController/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Controller = "User";
            ViewBag.Action = "Index";

            Auto auto = new Auto();
            auto = _context.Autos.SingleOrDefault(autos => autos.Id == id);
            ViewData["auto"] = auto;
            return View(auto);
        }

        // GET: AutoController/Create
        public ActionResult Create()
        {
            ViewBag.Controller = "User";
            ViewBag.Action = "Index";

            return View();
        }

        // POST: AutoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Auto auto)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var a = new Auto()
                    {
                        VehicleType = auto.VehicleType,
                        Category = auto.Category,
                        Brand = auto.Brand,
                        ModelName = auto.ModelName,
                        BuildYear = auto.BuildYear,
                        EngineSize = auto.EngineSize,
                        Price = auto.Price
                    };
                    _context.Autos.Add(a);
                    _context.SaveChanges();
                    TempData["msg"] = "Success";
                }
                else
                {
                    TempData["error"] = "Not Valid";
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AutoController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Controller = "User";
            ViewBag.Action = "Index";

            var autos = _context.Autos.SingleOrDefault(autos => autos.Id == id);
            return View(autos);
        }

        // POST: AutoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Auto autos)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Autos.Update(autos);
                    _context.SaveChanges();
                }
                else
                {
                    TempData["error"] = "Not Valid";
                }
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }

        // GET: AutoController/Delete/5
        public ActionResult Delete(int id)
        {
            var auto = _context.Autos.SingleOrDefault(autos => autos.Id == id);
            _context.Autos.Remove(auto);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
