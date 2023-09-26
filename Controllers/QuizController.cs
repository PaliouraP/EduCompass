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

        // TODO: Edit this code, because there can be duplicate questions.
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

        TempData["QuizId"] = quiz.Id;
        TempData.Keep("QuizId");
        
        return RedirectToAction("Quiz");
        
    }

    public IActionResult Quiz()
    {
        TempData.Keep("QuizId");
        
        // get the quiz object
        int quizId = int.Parse(TempData["QuizId"].ToString());
        var quiz = _database.CourseQuizGrades.First(q => q.Id == quizId);

        // create a list that maps the question for its answers
        var questionsAndAnswers = new Dictionary<Question, List<Answer>>();

        foreach (var questionIdString in quiz.QuestionIds.Split(';'))
        {
            // get the question object from the id
            int questionId = int.Parse(questionIdString);
            Question question = _database.Questions.First(q => q.Id == questionId);
            
            // get the answers of that question
            List<Answer> answers = _database.Answers.Where(a => a.QuestionId == questionId).ToList();
            
            questionsAndAnswers.Add(question, answers);
        }
        
        return View();
    }

    [HttpPost]
    public IActionResult PostAnswers(string answers)
    {
        
    }

    public IActionResult Finish()
    {
        
    }
    
    
}