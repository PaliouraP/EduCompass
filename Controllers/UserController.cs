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

        [HttpGet]
        public IActionResult EditProfile()
        {
            var model = _currentUser;
            
            return View(model);
        }

        [HttpPost]
        public IActionResult EditProfile(string username, string email, string firstname, string lastname, int semester)
        {
            // retrieve the user.
            var userToBeEdited = _database.Users.First(u => u.Username == _currentUser.Username);
            
            // check for duplicates.
            if (!string.IsNullOrEmpty(username))
            {
                if (_database.Users.Any(u => u.Username == username))
                {
                    TempData["Error"] = "To username που επιλέξατε είναι ήδη σε χρήση.";
                    return RedirectToAction("EditProfile");
                }
                
                HttpContext.Session.SetString("username", username);
            }
            
            if (!string.IsNullOrEmpty(email) && _database.Users.Any(u => u.Email == email))
            {
                TempData["Error"] = "To ηλεκτρονικό ταχυδρομείο που επιλέξατε είναι ήδη σε χρήση.";
                return RedirectToAction("EditProfile");
            }
            
            // edit user properties.
            userToBeEdited.Username = string.IsNullOrEmpty(username) ? userToBeEdited.Username : username;
            userToBeEdited.Email = string.IsNullOrEmpty(email) ? userToBeEdited.Email : email;
            userToBeEdited.FirstName = string.IsNullOrEmpty(firstname) ? userToBeEdited.FirstName : firstname;
            userToBeEdited.LastName = string.IsNullOrEmpty(lastname) ? userToBeEdited.LastName : lastname;
            userToBeEdited.Semester = semester == 0 ? userToBeEdited.Semester : semester;
            
            // apply the edited properties.
            _database.Users.Update(userToBeEdited);
            _database.SaveChanges();
            
            // redirect to the edit profile view.
            return RedirectToAction("Profile");
        }

        public IActionResult Statistics()
        {
            return View();
        }
    }
}
