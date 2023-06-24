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

        [HttpPost]
        public IActionResult Login(object obj)
        {
            // Get Parameters
            string username = Request.Form["usrnm"];
            string password = Request.Form["pswrd"];

            // Search by username first and then by email.
            User? user = _Database.Users.FirstOrDefault(u => (u.Username == username && u.Password == password) || (u.Email == username && u.Password == password));

            // If it doesn't exist, fail.
            if (user == null)
            {
                return RedirectToAction("Login");
            }

            // Otherwise redirect to dashboard.
            return RedirectToAction("Dashboard");
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
            // Get Parameters
            string username = Request.Form["usrnm"];
            string email = Request.Form["email"];
            string firstname = Request.Form["name"];
            string lastname = Request.Form["srname"];
            string semester = Request.Form["term"];
            string password = Request.Form["pswrd"];
            string password_confirmation = Request.Form["pswrd2"];

            //Debug.WriteLine($"{username}, {email}, {firstname}, {lastname}, {semester}, {password}, {password_confirmation}");

            // test cases for failing.
            if ( (from user in _Database.Users where user.Username == username select user).Any() )
            {
                // fail and display error to the user.
                Debug.WriteLine($"This should fail, because {username} a duplicate username.");
                return RedirectToAction("SignUp");
            }

            if ((from user in _Database.Users where user.Email == email select user).Any())
            {
                // fail and display error to the user.
                Debug.WriteLine($"This should fail, because {email} a duplicate username.");
                return RedirectToAction("SignUp");
            }

            if (password != password_confirmation)
            {
                // fail and display error to the user.
                Debug.WriteLine($"This should fail, because passwords don't match.");
                return RedirectToAction("SignUp");
                
            }

            // if none of the above cases fail, then create the user.
            User new_user = new User();
            new_user.Username = username;
            new_user.Email = email;
            new_user.FirstName = firstname;
            new_user.LastName = lastname;
            new_user.Semester = int.Parse(semester);
            new_user.Password = password;

            // add the user to the database.
            _Database.Add(new_user);

            _Database.SaveChanges();

            // and then redirect the user to home.
            return RedirectToAction("Dashboard");
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