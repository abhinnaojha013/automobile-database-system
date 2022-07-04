using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using automobile_database_system.Models;

namespace automobile_database_system.Controllers
{
    public class UserController : Controller
    {
        public VehicleDatabaseContext _context;
        public UserController(VehicleDatabaseContext context)
        {
            _context = context;
        }


        // GET: UserController
        public ActionResult Index()
        {
            ViewBag.Controller = "User";
            ViewBag.Action = "Index";
            return View();
        }

        // GET: UserController/Login
        public ActionResult Login()
        {
            ViewBag.Controller = "User";
            ViewBag.Action = "Index";
            return View();
        }

        // GET: UserController/Signup
        public ActionResult Signup()
        {
            ViewBag.Controller = "User";
            ViewBag.Action = "Index";
            return View();
        }
        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
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

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
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

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
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
