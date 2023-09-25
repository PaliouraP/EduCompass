using EduCompass.Data;
using EduCompass.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.IdentityModel.Tokens;

namespace EduCompass.Controllers;

public class IntroController : Controller
{
    private readonly ILogger<IntroController> _logger;
    private readonly ApplicationDbContext _database;
    private User _currentUser;

    public IntroController(ILogger<IntroController> logger, ApplicationDbContext database)
    {
        _logger = logger;
        _database = database;
    }
    
    // this method gets executed before any views.
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
    
    
    [HttpGet]
    public IActionResult IntroTest()
    {
        return View();
    }

    [HttpGet]
    public void NextCourse()
    {

    }

    [HttpPost]
    public IActionResult PostGrade(int courseId, int finalGrade, int interestScore)
    {
        var grade = new Grade
        {
            FinalGrade = finalGrade,
            InterestScore = interestScore,
            CourseId = courseId,
            UserId = _currentUser.Id
        };

        _database.Grades.Add(grade);
        _database.SaveChanges();

        return RedirectToAction("IntroTest");
    }

    public IActionResult Finished()
    {
        return View();
    }
}