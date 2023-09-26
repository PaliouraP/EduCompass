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
        var questions = _database.Questions.Where(q => q.CourseId == course.Id).ToList();
        questions = RandomizeList(questions);

        // create a string with all the question ids separated by a ';'
        var stringBuilder = new StringBuilder();

        stringBuilder.Append(questions[0].Id.ToString() + ';');
        stringBuilder.Append(questions[1].Id.ToString() + ';'); 
        stringBuilder.Append(questions[2].Id.ToString() + ';');
        stringBuilder.Append(questions[3].Id.ToString() + ';');
        stringBuilder.Append(questions[4].Id.ToString());

        string randomQuestionIds = stringBuilder.ToString();

        // create the quiz object
        var quiz = new CourseQuizGrade
        {
            QuestionIds = randomQuestionIds,
            AnswerIds = string.Empty,
            TimeStarted = DateTime.Now,
            CourseId = course.Id,
            UserId = _currentUser.Id
        };

        // add it to the database.
        _database.CourseQuizGrades.Add(quiz);
        _database.SaveChanges();

        // store the quiz id
        TempData["QuizId"] = quiz.Id;
        TempData.Keep("QuizId");
        
        // go to the quiz page
        return RedirectToAction("Quiz");
    }

    public IActionResult Quiz()
    {
        TempData.Keep("QuizId");
        
        // get the quiz object
        int quizId = int.Parse(TempData["QuizId"].ToString());
        var quiz = _database.CourseQuizGrades.First(q => q.Id == quizId);

        // create a list that maps the question for its answers
        var questionsAndAnswers = new Dictionary<Question, Answer>();

        foreach (var questionIdString in quiz.QuestionIds.Split(';'))
        {
            // get the question object from the id
            int questionId = int.Parse(questionIdString);
            Question question = _database.Questions.First(q => q.Id == questionId);
            
            // get the answers of that question
            Answer answers = _database.Answers.First(a => a.QuestionId == questionId);

            questionsAndAnswers.Add(question, answers);
        }

        // get the course that the quiz is about.
        var course = _database.Courses.First(c => c.Id == quiz.CourseId);
        
        // return the model.
        var model = new Tuple<Course, Dictionary<Question, Answer>>(course, questionsAndAnswers);
        return View(model);
    }

    [HttpPost]
    public IActionResult PostAnswers(string answers)
    {
        return RedirectToAction("Dashboard", "Home");
    }

    public IActionResult FinishedExam()
    {
        return View();
    }
    
    private static List<T> RandomizeList<T>(List<T> list)
    {
        Random random = new Random();
        int n = list.Count;
        
        for (int i = n - 1; i > 0; i--)
        {
            // Generate a random index to swap with the current element.
            int j = random.Next(0, i + 1);

            // Swap the elements at i and j.
            (list[i], list[j]) = (list[j], list[i]);
        }
        
        return list;
    }
}