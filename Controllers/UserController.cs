using EduCompass.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EduCompass.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly ApplicationDbContext _database;

        public UserController(ILogger<UserController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _database = db;
        }
        
        // this method gets executed before any views.
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // if the session exists, do nothing.
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("username"))) return;
            
            // if it doesn't, then log the user out.
            TempData["Error"] = "Your session has expired. Please log in again.";
            context.Result = RedirectToAction("Login", "Auth");
            base.OnActionExecuting(context);
        }
        
        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Statistics()
        {
            return View();
        }
    }
}
