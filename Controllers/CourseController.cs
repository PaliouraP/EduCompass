using EduCompass.Data;
using EduCompass.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EduCompass.Controllers
{
    public class CourseController : Controller
    {
        private ILogger<CourseController> _logger;
        private ApplicationDbContext _database;
        private User? _currentUser;

        public CourseController(ILogger<CourseController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _database = db;
        }
        
        /// <summary>
        /// This method gets executed before any view is rendered.
        /// <b>Before any action runs, we want to ensure that the user's session hasn't expired. If it has, we log the user out</b>
        /// </summary>
        /// <param name="context">The context responsible for redirecting to the correct page.</param>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // if the session exists, do nothing.
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("username")))
            {
                // if it doesn't, then log the user out.
                TempData["Error"] = "⚠️ Ουπς! Φαίνεται ότι η σύνοδός σας έχει λήξει. Παρακαλώ ξανασυνδεθείτε.";
                context.Result = RedirectToAction("Login", "Auth");
                base.OnActionExecuting(context);
                return;
            }

            _currentUser = _database.Users.First(u => u.Username == HttpContext.Session.GetString("username"));
        }

        public IActionResult OrientationPage()
        {
            var model = new Tuple<List<Coefficient>, List<CourseHasCoefficient>, List<Course>, List<CourseQuizGrade>, List<PrerequisiteCourse>>
                (_database.Coefficients.ToList(), _database.CourseHasCoefficients.ToList(), _database.Courses.ToList(), _database.CourseQuizGrades.ToList(), _database.PrerequisiteCourses.ToList());
            
            return View(model);
        }
        
        [HttpGet]
        public IActionResult CoursePage(string uuid)
        {
            // TODO: Add check for locked course.
            var course = _database.Courses.First(c => c.UUID == uuid);
            
            //if (course == null)
                //throw new Exception("This course doesn't exist!");
            
            // prerequisite courses.
            var necessaryCourseIds = _database.PrerequisiteCourses.Where(p => p.BaseCourseId == course.Id).ToList();
            var necessaryCourses = (from pc in necessaryCourseIds join _course in _database.Courses on pc.PrerequisiteCourseId equals _course.Id select _course).ToList();

            // coefficients related to a career
            var baseCourseCoefficients = _database.CourseHasCoefficients.Where(chc => chc.Value > 5 && chc.CourseId == course.Id).ToList();
            var careers = (from chc in baseCourseCoefficients
                join career in _database.Careers on chc.CoefficientName equals career.CoefficientName
                select career).ToList();

            var model = new Tuple<Course, List<Course>, List<Career>, List<CourseQuizGrade>>(course, necessaryCourses, careers, _database.CourseQuizGrades.ToList());
            
            return View(model);
        }
    }
}
