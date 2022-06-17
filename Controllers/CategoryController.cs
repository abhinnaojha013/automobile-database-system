using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace automobile_database_system.Controllers
{
    public class CategoryController : Controller
    {
        // GET: CategoryController
        public ActionResult Index()
        {
            ViewBag.Controller = "User";
            ViewBag.Action = "Index";
            return View();
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
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
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
            ViewBag.Id = id;
            ViewBag.categoryName = "Cruiser";
            return View(id);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
