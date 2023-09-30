using System.Text;
using EduCompass.Data;
using EduCompass.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.IdentityModel.Tokens;

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

    public IActionResult StartCourseQuiz(string courseUUID)
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
        return RedirectToAction("CourseQuiz");
    }
    

    public IActionResult CourseQuiz()
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

        if (!Request.Form["cancel"].ToString().IsNullOrEmpty())
        {
            var courseUUID = _database.Courses.First(c => c.Id == quiz.CourseId).UUID;
            return RedirectToAction("CoursePage", "Course", new { uuid = courseUUID });
        }

        var questionIds = quiz.QuestionIds.Split(';');
        
        // get the user's answers
        var answer1 = Request.Form[$"answer-{questionIds[0]}"].ToString();
        var answer2 = Request.Form[$"answer-{questionIds[1]}"].ToString();
        var answer3 = Request.Form[$"answer-{questionIds[2]}"].ToString();
        var answer4 = Request.Form[$"answer-{questionIds[3]}"].ToString();
        var answer5 = Request.Form[$"answer-{questionIds[4]}"].ToString();

        // create the answer string to store it to the database.
        string answersString = $"{answer1};{answer2};{answer3};{answer4};{answer5}";
        
        // calculate accuracy
        int correctAnswerCounter = 0;
        
        for (int i = 0; i < 5; i++)
        {
            var stringQuestions = quiz.QuestionIds.Split(';');
            
            // get the question object from the id
            int questionId = int.Parse(stringQuestions[i]);

            // get the answers of that question
            Answer answers = _database.Answers.First(a => a.QuestionId == questionId);

            if (answers.CorrectAnswer.ToLower().Trim().Equals(Request.Form[$"answer-{questionId}"].ToString().Trim().ToLower()))
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
        if (grade >= 50)
            return RedirectToAction("FinishedExam");

        return RedirectToAction("FailedExam");
    }

    public IActionResult FinishedExam()
    {
        TempData.Keep("QuizId");
        
        // get the quiz object
        int quizId = int.Parse(TempData["QuizId"].ToString());
        var quiz = _database.CourseQuizGrades.First(q => q.Id == quizId);

        // get the questions the and the user's answers
        var questionIdsArray = quiz.QuestionIds.Split(';');
        var answerStrings = quiz.AnswerIds.Split(';');
        
        // create a dictionary mapping two strings
        var quizWithQuestionsAndCorrectAnswers = new Dictionary<Question, string>();

        for (int i = 0; i < questionIdsArray.Length; i++)
        {
            // get question and right answer
            Question currentQuestion = _database.Questions.First(q => q.Id == int.Parse(questionIdsArray[i]));
            var correctAnswer = _database.Answers.First(a => a.QuestionId == currentQuestion.Id).CorrectAnswer;

            // see if the answer was right and write it down.
            string answerString = correctAnswer.Trim().ToLower().Equals(answerStrings[i].Trim().ToLower()) ? $"{correctAnswer} (ΣΩΣΤΗ ΑΠΑΝΤΗΣΗ)" : $"{answerStrings[i]} (ΛΑΘΟΣ ΑΠΑΝΤΗΣΗ) Σωστή Απάντηση: {correctAnswer}";

            // add it to the dictionary
            quizWithQuestionsAndCorrectAnswers.Add(currentQuestion, answerString);
        }

        // create the model and return it.
        var model = new Tuple<CourseQuizGrade, Dictionary<Question, string>>(quiz, quizWithQuestionsAndCorrectAnswers);
        return View(model);
    }

    public IActionResult FailedExam()
    {
        TempData.Keep("QuizId");
        
        // get the quiz object
        int quizId = int.Parse(TempData["QuizId"].ToString());
        var quiz = _database.CourseQuizGrades.First(q => q.Id == quizId);

        // get the questions the and the user's answers
        var questionIdsArray = quiz.QuestionIds.Split(';');
        var answerStrings = quiz.AnswerIds.Split(';');
        
        // create a dictionary mapping two strings
        var quizWithQuestionsAndCorrectAnswers = new Dictionary<Question, string>();

        for (int i = 0; i < questionIdsArray.Length; i++)
        {
            // get question and right answer
            Question currentQuestion = _database.Questions.First(q => q.Id == int.Parse(questionIdsArray[i]));
            var correctAnswer = _database.Answers.First(a => a.QuestionId == currentQuestion.Id).CorrectAnswer;

            // see if the answer was right and write it down.
            string answerString = correctAnswer.Trim().ToLower().Equals(answerStrings[i].Trim().ToLower()) ? $"{correctAnswer} (ΣΩΣΤΗ ΑΠΑΝΤΗΣΗ)" : $"{answerStrings[i]} (ΛΑΘΟΣ ΑΠΑΝΤΗΣΗ) Σωστή Απάντηση: {correctAnswer}";

            // add it to the dictionary
            quizWithQuestionsAndCorrectAnswers.Add(currentQuestion, answerString);
        }

        // create the model and return it.
        var model = new Tuple<CourseQuizGrade, Dictionary<Question, string>>(quiz, quizWithQuestionsAndCorrectAnswers);
        return View(model);
    }

    public IActionResult StartEvaluationTest(string coefficientName)
    {
        var quiz = new CoefficientQuizGrade();

        // get course Ids with that coefficient.
        var courseIdsWithThatCoefficient =
            _database.CourseHasCoefficients.Where(chc => chc.CoefficientName == coefficientName && chc.Value > 0).ToList();

        var allQuestions = new List<Question>();
        
        // get 3 questions from each course.
        foreach (var courseId in courseIdsWithThatCoefficient)
        {
            // take all questions from each course, and then randomize them.
            var questionsFromThisCourse = _database.Questions.Where(q => q.CourseId == courseId.CourseId).ToList();
            questionsFromThisCourse = RandomizeList(questionsFromThisCourse);
            
            // then take three and save them to the all questions list.
            questionsFromThisCourse = questionsFromThisCourse.Take(3).ToList();
            questionsFromThisCourse.ForEach(q => allQuestions.Add(q));
        }

        // get the question ids and save it to the string.
        int[] allQuestionIds = allQuestions.Select(q => q.Id).ToArray();
        string stringQuestionIds = string.Join(';', allQuestionIds);

        // create the quiz.
        quiz.CoefficientName = coefficientName;
        quiz.QuestionIds = stringQuestionIds;
        quiz.TimeStarted = DateTime.Now;
        quiz.AnswerStrings = string.Empty;
        quiz.UserId = _currentUser.Id;
        
        // and add it to the database.
        _database.CoefficientQuizGrades.Add(quiz);
        _database.SaveChanges();

        // save the id
        TempData["coefficientQuizId"] = quiz.Id;
        TempData.Keep("coefficientQuizId");

        return RedirectToAction("EvaluationQuiz");
    }

    public IActionResult EvaluationQuiz()
    {
        // evaluation test ids
        TempData.Keep("coefficientQuizId");
        int quizId = int.Parse(TempData["coefficientQuizId"].ToString());
        
        // get the object.
        var evaluationTest = _database.CoefficientQuizGrades.First(cq => cq.Id == quizId);
        
        // create a list that maps the question for its answers
        var questionsAndAnswers = new Dictionary<Question, Answer>();
        
        foreach (var questionIdString in evaluationTest.QuestionIds.Split(';'))
        {
            // get the question object from the id
            int questionId = int.Parse(questionIdString);
            Question question = _database.Questions.First(q => q.Id == questionId);
            
            // get the answers of that question
            Answer answers = _database.Answers.First(a => a.QuestionId == questionId);

            questionsAndAnswers.Add(question, answers);
        }

        // get the course that the quiz is about.
        var coefficient = _database.Coefficients.First(c => c.Name == evaluationTest.CoefficientName);
        
        // return the model.
        var model = new Tuple<Coefficient, Dictionary<Question, Answer>>(coefficient, questionsAndAnswers);
        return View(model);
    }

    [HttpPost]
    public IActionResult PostEvaluationAnswers()
    {
        // find the evaluation test id.
        TempData.Keep("coefficientQuizId");
        int quizId = int.Parse(TempData["coefficientQuizId"].ToString());
        
        if (!Request.Form["cancel"].ToString().IsNullOrEmpty())
            return RedirectToAction("OrientationPage", "Course");
        
        // get the object.
        var evaluationTest = _database.CoefficientQuizGrades.First(cq => cq.Id == quizId);
        
        // get the question ids.
        var questionIds = evaluationTest.QuestionIds.Split(';');
        var userAnswers = new List<string>();

        // get the user's answers
        for (int i = 0; i < questionIds.Length; i++)
        {
            var userAnswer = Request.Form[$"answer-{questionIds[i]}"].ToString();
            userAnswers.Add(userAnswer);
        }

        // create the string to save it to the quiz
        string answersString = string.Join(';', userAnswers);

        // calculate the correct answer count.
        int correctAnswerCounter = 0;
        for (int i = 0; i < questionIds.Length; i++)
        {
            // get the question id and the answer that corresponds to it.
            int questionId = int.Parse(questionIds[i]);
            Answer answer = _database.Answers.First(a => a.QuestionId == questionId);

            if (answer.CorrectAnswer.ToLower().Trim().Equals(userAnswers[i].ToLower().Trim()))
                correctAnswerCounter++;
        }

        // calculate the grade.
        int grade = 100 * correctAnswerCounter / questionIds.Length;
        
        // update the evaluation test object.
        evaluationTest.Grade = grade;
        evaluationTest.AnswerStrings = answersString;
        evaluationTest.TimeFinished = DateTime.Now;
        
        // store it to the database.
        _database.CoefficientQuizGrades.Update(evaluationTest);
        _database.SaveChanges();
        
        // redirect to finished.
        if (grade >= 50)
            return RedirectToAction("FinishedEvaluation");

        return RedirectToAction("FailedEvaluation");
    }
    
    public IActionResult FailedEvaluation()
    {
        // find the evaluation test id.
        TempData.Keep("coefficientQuizId");
        
        int quizId = int.Parse(TempData["coefficientQuizId"].ToString());
        var quiz = _database.CoefficientQuizGrades.First(q => q.Id == quizId);
        
        // get the questions the and the user's answers
        var questionIdsArray = quiz.QuestionIds.Split(';');
        var answerStrings = quiz.AnswerStrings.Split(';');
        
        // create a dictionary mapping two strings
        var quizWithQuestionsAndCorrectAnswers = new Dictionary<Question, string>();
        
        for (int i = 0; i < questionIdsArray.Length; i++)
        {
            // get question and right answer
            Question currentQuestion = _database.Questions.First(q => q.Id == int.Parse(questionIdsArray[i]));
            var correctAnswer = _database.Answers.First(a => a.QuestionId == currentQuestion.Id).CorrectAnswer;

            // see if the answer was right and write it down.
            string answerString = correctAnswer.Trim().ToLower().Equals(answerStrings[i].Trim().ToLower()) ? $"{correctAnswer} (ΣΩΣΤΗ ΑΠΑΝΤΗΣΗ)" : $"{answerStrings[i]} (ΛΑΘΟΣ ΑΠΑΝΤΗΣΗ) Σωστή Απάντηση: {correctAnswer}";

            // add it to the dictionary
            quizWithQuestionsAndCorrectAnswers.Add(currentQuestion, answerString);
        }
        
        // create the model and return it.
        var model = new Tuple<CoefficientQuizGrade, Dictionary<Question, string>>(quiz, quizWithQuestionsAndCorrectAnswers);
        return View(model);
    }

    public IActionResult FinishedEvaluation()
    {
        // find the evaluation test id.
        TempData.Keep("coefficientQuizId");
        
        int quizId = int.Parse(TempData["coefficientQuizId"].ToString());
        var quiz = _database.CoefficientQuizGrades.First(q => q.Id == quizId);
        
        // get the questions the and the user's answers
        var questionIdsArray = quiz.QuestionIds.Split(';');
        var answerStrings = quiz.AnswerStrings.Split(';');
        
        // create a dictionary mapping two strings
        var quizWithQuestionsAndCorrectAnswers = new Dictionary<Question, string>();
        
        for (int i = 0; i < questionIdsArray.Length; i++)
        {
            // get question and right answer
            Question currentQuestion = _database.Questions.First(q => q.Id == int.Parse(questionIdsArray[i]));
            var correctAnswer = _database.Answers.First(a => a.QuestionId == currentQuestion.Id).CorrectAnswer;

            // see if the answer was right and write it down.
            string answerString = correctAnswer.Trim().ToLower().Equals(answerStrings[i].Trim().ToLower()) ? $"{correctAnswer} (ΣΩΣΤΗ ΑΠΑΝΤΗΣΗ)" : $"{answerStrings[i]} (ΛΑΘΟΣ ΑΠΑΝΤΗΣΗ) Σωστή Απάντηση: {correctAnswer}";

            // add it to the dictionary
            quizWithQuestionsAndCorrectAnswers.Add(currentQuestion, answerString);
        }
        
        // create the model and return it.
        var model = new Tuple<CoefficientQuizGrade, Dictionary<Question, string>>(quiz, quizWithQuestionsAndCorrectAnswers);
        return View(model);
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