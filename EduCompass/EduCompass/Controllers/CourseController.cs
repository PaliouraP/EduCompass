using Microsoft.AspNetCore.Mvc;

namespace EduCompass.Controllers
{
    public class CourseController : Controller
    {
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
