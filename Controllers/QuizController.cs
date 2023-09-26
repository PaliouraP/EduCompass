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
    public IActionResult PostAnswers()
    {
        TempData.Keep("QuizId");
        
        // get the quiz object
        int quizId = int.Parse(TempData["QuizId"].ToString());
        var quiz = _database.CourseQuizGrades.First(q => q.Id == quizId);
        
        // get the user's answers
        var answer1 = Request.Form["answer-1"].ToString();
        var answer2 = Request.Form["answer-2"].ToString();
        var answer3 = Request.Form["answer-3"].ToString();
        var answer4 = Request.Form["answer-4"].ToString();
        var answer5 = Request.Form["answer-5"].ToString();

        // create the answer string to store it to the database.
        string answersString = $"{answer1};{answer2};{answer3};{answer4};{answer5}";
        
        // calculate accuracy
        int correctAnswerCounter = 0;
        
        for (int i = 0; i < 5; i++)
        {
            var stringAnswers = answersString.Split(';');
            var stringQuestions = quiz.QuestionIds.Split(';');
            Array.Sort(stringQuestions);
            
            // get the question object from the id
            int questionId = int.Parse(stringQuestions[i]);

            // get the answers of that question
            Answer answers = _database.Answers.First(a => a.QuestionId == questionId);

            if (string.Equals(answers.CorrectAnswer, stringAnswers[i], StringComparison.CurrentCultureIgnoreCase))
                correctAnswerCounter++;
        }

        // calculate grade
        int grade = 100 * correctAnswerCounter / 5;

        // store the data to the quiz object.
        quiz.Grade = grade;
        quiz.AnswerIds = answersString;
        quiz.TimeFinished = DateTime.Now;

        // save the changes to the database.
        _database.Update(quiz);
        _database.SaveChanges();

        // return to finished
        return RedirectToAction("FinishedExam");
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