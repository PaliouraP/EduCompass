using System.Text;
using EduCompass.Data;
using EduCompass.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EduCompass.Controllers;

public class QuizController : Controller
{
    private ILogger<QuizController> _logger;
    private ApplicationDbContext _database;
    private User? _currentUser;

    public QuizController(ILogger<QuizController> logger, ApplicationDbContext database)
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

    public IActionResult StartQuiz(string courseUUID)
    {
        // retrieve the course
        var course = _database.Courses.First(c => c.UUID == courseUUID);

        // retrieve random question ids
        var stringBuilder = new StringBuilder();
        var rng = new Random();

        for (var i = 0; i < 5; i++)
            stringBuilder.Append(rng.Next(1, 11).ToString() + ';');

        var randomQuestionIds = stringBuilder.ToString();

        var quiz = new CourseQuizGrade
        {
            QuestionIds = randomQuestionIds,
            AnswerIds = string.Empty,
            TimeStarted = DateTime.Now,
            CourseId = course.Id,
            UserId = _currentUser.Id
        };

        _database.CourseQuizGrades.Add(quiz);
        _database.SaveChanges();

        return RedirectToAction("Quiz");
    }

    public IActionResult Quiz()
    {
        return View();
    }
    
    
}