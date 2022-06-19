using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace automobile_database_system.Controllers
{
    public class AutoController : Controller
    {
        // GET: AutoController
        public ActionResult Index()
        {
            ViewBag.Controller = "User";
            ViewBag.Action = "Index";
            return View();
        }

        // GET: AutoController/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Controller = "User";
            ViewBag.Action = "Index";
            return View();
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

        // GET: AutoController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Controller = "User";
            ViewBag.Action = "Index";
            return View();
        }

        // POST: AutoController/Edit/5
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

        // GET: AutoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AutoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
