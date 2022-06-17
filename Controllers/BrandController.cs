using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace automobile_database_system.Controllers
{
    public class BrandController : Controller
    {
        // GET: BrandController
        public ActionResult Index()
        {
            ViewBag.Controller = "User";
            ViewBag.Action = "Index";
            return View();
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

        // GET: BrandController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Controller = "User";
            ViewBag.Action = "Index";
            ViewBag.Id = id;
            ViewBag.brandName = "Honda";
            return View(id);
        }

        // POST: BrandController/Edit/5
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
