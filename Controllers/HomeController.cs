using EduCompass.Data;
using EduCompass.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EduCompass.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _database;
        private User _currentUser; 

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _database = db;
        }
        
        // this method gets executed before any views.
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // if the session exists, do nothing.
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("username")))
            {
                // if it doesn't, then log the user out.
                TempData["Error"] = "Your session has expired. Please log in again.";
                context.Result = RedirectToAction("Login", "Auth");
                base.OnActionExecuting(context);
            }

            _currentUser = _database.Users.First(u => u.Username == HttpContext.Session.GetString("username"));
        }
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IntroTest()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Quiz()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}