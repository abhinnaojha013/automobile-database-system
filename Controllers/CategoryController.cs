using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using automobile_database_system.Models;

namespace automobile_database_system.Controllers
{
    public class CategoryController : Controller
    {
        public VehicleDatabaseContext _context;
        public CategoryController(VehicleDatabaseContext context)
        {
            _context = context;
        }


        // GET: CategoryController
        public ActionResult Index()
        {
            ViewBag.Controller = "User";
            ViewBag.Action = "Index";

            var categories = _context.Categories.ToList();
            return View(categories);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            ViewBag.Controller = "User";
            ViewBag.Action = "Index";
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var c = new Category()
                    {
                        Name = category.Name,
                        Type = category.Type
                    };
                    _context.Categories.Add(c);
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

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Controller = "User";
            ViewBag.Action = "Index";

            var categories = _context.Categories.SingleOrDefault(categories => categories.Id == id);
            return View(categories);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category categories)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Categories.Update(categories);
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
