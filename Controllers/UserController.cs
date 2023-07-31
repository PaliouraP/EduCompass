using Microsoft.AspNetCore.Mvc;

namespace EduCompass.Controllers
{
    public class UserController : Controller
    {
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
