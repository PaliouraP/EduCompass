using EduCompass.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EduCompass.Controllers
{
    public class CourseController : Controller
    {
        private ILogger<CourseController> _logger;
        private ApplicationDbContext _database;

        public CourseController(ILogger<CourseController> logger, ApplicationDbContext db)
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

        public IActionResult SemesterPage()
        {
            return View();
        }
        
        public IActionResult CoursePage()
        {
            return View();
        }
    }
}
