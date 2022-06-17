using automobile_database_system.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace automobile_database_system.Controllers
{
    public class MainController : Controller
    {
        // GET: MainController
        public ActionResult Index()
        {
            ViewBag.Controller = "Main";
            ViewBag.Action = "Index";
            return View();
        }

        // GET: MainController/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Controller = "Main";
            ViewBag.Action = "Index";
            ViewBag.Id = id;
            ViewBag.auto = "<brand> <model>";
            return View(id);
        }
    }
}
