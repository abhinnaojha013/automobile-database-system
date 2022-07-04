using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using automobile_database_system.Models;

namespace automobile_database_system.Controllers
{
    public class BrandController : Controller
    {
        public VehicleDatabaseContext _context;
        public BrandController(VehicleDatabaseContext context)
        {
            _context = context;
        }

        // GET: BrandController
        public ActionResult Index()
        {
            ViewBag.Controller = "User";
            ViewBag.Action = "Index";

            var brands = _context.Brands.ToList();
            return View(brands);
        }

        // GET: BrandController/Create
        public ActionResult Create()
        {
            ViewBag.Controller = "User";
            ViewBag.Action = "Index";

            return View();
        }

        // POST: BrandController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Brand brand)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var b = new Brand()
                    {
                        BrandName = brand.BrandName
                    };
                    _context.Brands.Add(b);
                    _context.SaveChanges();
                    TempData["msg"] = "Success";
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BrandController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Controller = "User";
            ViewBag.Action = "Index";

            var brands = _context.Brands.SingleOrDefault(brands => brands.Id == id);
            return View(brands);
        }

        // POST: BrandController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Brand brands)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Brands.Update(brands);
                    _context.SaveChanges();
                }
            }
            catch
            {
                return View();
            }
            return RedirectToAction("Index");
        }
    }
}
