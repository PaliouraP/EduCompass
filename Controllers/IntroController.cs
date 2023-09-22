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
            TempData["Error"] = "Ουπς! Φαίνεται ότι η συνεδρία σας έχει λήξει. Παρακαλώ ξανασυνδεθείτε.";
            context.Result = RedirectToAction("Login", "Auth");
            base.OnActionExecuting(context);
            return;
        }

        _currentUser = _database.Users.First(u => u.Username == HttpContext.Session.GetString("username"));
    }
    
    
    [HttpGet]
    public IActionResult IntroTest(string? courseUUID)
    {
        // if the courseUUID is not typed
        if (courseUUID.IsNullOrEmpty())
        {
            // get all the courses that should be on the intro test.
            var coursesInIntro = _database.Courses.Where(c => c.InIntro).ToList();

            // initialize a null course for after.
            Course courseToBeAdded = null;
            
            // for every course that exists in the intro test...
            foreach (var course in coursesInIntro)
            {
                // check if there is grade for the user. If there is, skip it.
                if (_database.Grades.Any(g => g.CourseUUID == course.UUID && g.UserId == _currentUser.Id))
                    continue;

                // otherwise the course to be displayed is the one with no grade from the user.
                courseToBeAdded = course;
                break;
            }

            // if all the courses have grade regarding the user, the user has finished the intro test.
            if (courseToBeAdded == null)
                return RedirectToAction("Finished");

            // if the course is not null, display the course
            return RedirectToAction("IntroTest", new { courseUUID = courseToBeAdded.UUID });
        }

        var model = _database.Courses.First(c => c.UUID == courseUUID);
        return View(model);
    }

    [HttpPost]
    public IActionResult PostGrade(string courseUUID, int finalGrade, int interestScore)
    {
        var grade = new Grade
        {
            FinalGrade = finalGrade,
            InterestScore = interestScore,
            CourseUUID = courseUUID,
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