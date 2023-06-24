using EduCompass.Data;
using EduCompass.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EduCompass.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _Database;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _Database = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        // GET
        public IActionResult SignUp()
        {
            return View();
        }

        //POST
        [HttpPost]
        public IActionResult SignUp(User obj)
        {
            string username = Request.Form["usrnm"];
            string email = Request.Form["email"];
            string firstname = Request.Form["name"];
            string lastname = Request.Form["srname"];
            string semester = Request.Form["term"];
            string password = Request.Form["pswrd"];
            string password_confirmation = Request.Form["pswrd2"];

            Debug.WriteLine($"{username}, {email}, {firstname}, {lastname}, {semester}, {password}, {password_confirmation}");

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