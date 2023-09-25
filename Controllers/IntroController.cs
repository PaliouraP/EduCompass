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
    private int[] _courseIdsInSemesterOrder;

    public IntroController(ILogger<IntroController> logger, ApplicationDbContext database)
    {
        _logger = logger;
        _database = database;
        _courseIdsInSemesterOrder = _database.Courses.OrderBy(c => c.Semester).Select(c => c.Id).ToArray();
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
    public IActionResult IntroTest(string uuid)
    {
        var model = _database.Courses.First(c => c.UUID == uuid);

        if (model == null)
            throw new Exception("Wrong Course UUID");
        
        return View(model);
    }

    [HttpGet]
    public IActionResult StartIntroTest()
    {
        // redirect to Intro Test with the first course.
        var startingCourseUUID = _database.Courses.First(c => c.Id == _courseIdsInSemesterOrder[0]).UUID;
        
        return RedirectToAction("IntroTest", new { uuid = startingCourseUUID });
    }

    [HttpPost]
    public IActionResult NextOrPreviousCourse(string direction, string currentUuid, int? finalGrade, int? interestScore)
    {
        // NEXT
        if (direction == "next")
        {
            // find the current course that the user is in.
            var course = _database.Courses.First(c => c.UUID == currentUuid);

            // add the grade to the database.
            var grade = new Grade
            {
                CourseId = course.Id,
                Created = DateTime.Now,
                FinalGrade = finalGrade ?? -1,
                InterestScore = interestScore ?? -1,
                UserId = _currentUser.Id
            };
        
            _database.Grades.Add(grade);
            _database.SaveChanges();

            // find the index of that course.
            int index = Array.IndexOf(_courseIdsInSemesterOrder, course.Id);

            // if there is a next course, go to it.
            if (index != _courseIdsInSemesterOrder.Length - 1)
            {
                string nextCourseUUID = _database.Courses.First(c => c.Id == _courseIdsInSemesterOrder[index + 1]).UUID;
                return RedirectToAction("IntroTest", new { uuid = nextCourseUUID });
            }

            // otherwise there is no course left.
            return RedirectToAction("Finished");
        }
        
        // PREV
        
        // find the current course that the user is in.
        var course1 = _database.Courses.First(c => c.UUID == currentUuid);

        // find the index of that course.
        int index1 = Array.IndexOf(_courseIdsInSemesterOrder, course1.Id);

        // if there is a next course, go to it.
        if (index1 != 0)
        {
            string nextCourseUUID = _database.Courses.First(c => c.Id == _courseIdsInSemesterOrder[index1 - 1]).UUID;
            return RedirectToAction("IntroTest", new { uuid = nextCourseUUID });
        }

        // otherwise there is no course left.
        return RedirectToAction("StartIntroTest");
    }
    

    public IActionResult Finished()
    {
        return View();
    }
}