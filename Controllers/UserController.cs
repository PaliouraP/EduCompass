using EduCompass.Data;
using EduCompass.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EduCompass.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly ApplicationDbContext _database;
        private User _currentUser;

        public UserController(ILogger<UserController> logger, ApplicationDbContext db)
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
                return;
            }

            _currentUser = _database.Users.First(u => u.Username == HttpContext.Session.GetString("username"));
        }
        
        public IActionResult Profile()
        {
            var model = _currentUser;
            
            return View(model);
        }

        public IActionResult Statistics()
        {
            return View();
        }
    }
}
