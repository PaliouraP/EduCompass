using System.Diagnostics;
using EduCompass.Classes;
using EduCompass.Data;
using EduCompass.Models;
using Microsoft.AspNetCore.Mvc;

namespace EduCompass.Controllers;

public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;
    private readonly ApplicationDbContext _database;

    public AuthController(ILogger<AuthController> logger, ApplicationDbContext db)
    {
        _logger = logger;
        _database = db;
    }
    
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string usrnm, string pswrd)
    {
        // Search by username first and then by email.
        var user = _database.Users.FirstOrDefault(u => u.Username == usrnm || u.Email == usrnm);

        // If it doesn't exist, fail.
        if (user == null)
        {
            TempData["Error"] = "❌  Λάθος στοιχεία. Παρακαλώ προσπαθήστε ξανά.";
            return RedirectToAction("Login");
        }

        // If the password isn't valid, fail.
        if (!PasswordManager.VerifyPassword(pswrd, user.Password))
        {
            TempData["Error"] = "❌  Λάθος στοιχεία. Παρακαλώ προσπαθήστε ξανά.";
            return RedirectToAction("Login");
        }

        // Otherwise redirect to dashboard or the intro test if it's not completed yet.
        CreateSession(user.Username);
        
        if (user.HasCompletedIntroTest)
            return RedirectToAction("Dashboard", "Home");

        return RedirectToAction("StartIntroTest", "Intro");
    }

    // GET
    public IActionResult SignUp()
    {
        return View();
    }

    //POST
    [HttpPost]
    public IActionResult SignUp(string usrnm, string email, string name, string srname, string pswrd, string pswrd2)
    {
        // test cases for failing.
        if ( (from user in _database.Users where user.Username == usrnm select user).Any() )
        {
            // fail and display error to the user.
            Debug.WriteLine($"This should fail, because {usrnm} a duplicate username.");
            TempData["Error"] = "To όνομα χρήστη που επιλέξατε είναι ήδη σε χρήση.";
            return RedirectToAction("SignUp");
        }

        if ((from user in _database.Users where user.Email == email select user).Any())
        {
            // fail and display error to the user.
            Debug.WriteLine($"This should fail, because {email} a duplicate username.");
            TempData["Error"] = "To ηλεκτρονικό ταχυδρομείο που επιλέξατε είναι ήδη σε χρήση";
            return RedirectToAction("SignUp");
        }

        if (pswrd != pswrd2)
        {
            // fail and display error to the user.
            Debug.WriteLine($"This should fail, because passwords don't match.");
            TempData["Error"] = "Βεβαιωθείτε ότι εισάγετε το ίδιο συνθηματικό και στα δύο πεδία κωδικού.";
            return RedirectToAction("SignUp");
        }

        // if none of the above cases fail, then create the user.
        var newUser = new User
        {
            Username = usrnm,
            Email = email,
            FirstName = name,
            LastName = srname,
            Password = PasswordManager.HashPassword(pswrd)
        };

        // add the user to the database.
        _database.Add(newUser);
        _database.SaveChanges();

        // and then redirect the user to the start of the intro test.
        CreateSession(newUser.Username);
        return RedirectToAction("StartIntroTest", "Intro");
    }

    public IActionResult Logout()
    {
        DestroySession();
        return RedirectToAction("Login");
    }

    private void CreateSession(string username)
    {
        HttpContext.Session.SetString("username", username);
    }

    private void DestroySession()
    {
        HttpContext.Session.SetString("username", string.Empty);
    }
}