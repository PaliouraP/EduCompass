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
                TempData["Error"] = "Ουπς! Φαίνεται ότι η συνεδρία σας έχει λήξει. Παρακαλώ ξανασυνδεθείτε.";
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

        [HttpGet]
        public IActionResult RedoIntroTest()
        {
            // delete all the user grades.
            var userGrades = _database.Grades.Where(g => g.UserId == _currentUser.Id).ToArray();
            foreach (var userGrade in userGrades)
                _database.Grades.Remove(userGrade);

            // also remove the hascompletedintro in the user.
            _currentUser.HasCompletedIntroTest = false;
            _database.Users.Update(_currentUser);

            // redirect to the correct action
            return RedirectToAction("StartIntroTest", "Intro");
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
                    TempData["Error"] = "To όνομα χρήστη που επιλέξατε είναι ήδη σε χρήση.";
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
            
            // apply the edited properties.
            _database.Users.Update(userToBeEdited);
            _database.SaveChanges();
            
            // redirect to the edit profile view.
            return RedirectToAction("Profile");
        }

        public IActionResult Statistics()
        {
            var allCoefficients = _database.Coefficients.ToArray();

            var CoefficientActualGradeDictionary = new Dictionary<Coefficient, double>();
            var CoefficientInterestScoreDictionary = new Dictionary<Coefficient, double>();
            var CoefficientQuizScoreDictionary = new Dictionary<Coefficient, double>();
            var CoefficientGeneralDictionary = new Dictionary<Coefficient, double>();

            _currentUser.CalculateUserCoefficients(_database);

            foreach (var coefficient in allCoefficients)
            {
                var coursesInThatCoefficient = _database.CourseHasCoefficients
                    .Where(chc => chc.CoefficientName == coefficient.Name).ToArray();

                int totalCoefficientPoints = 0;
                
                double totalActualGrade = 0f;
                double totalInterestScore = 0f;
                double totalQuizGradeScore = 0f;

                foreach (var course in coursesInThatCoefficient)
                {
                    Grade? userCourseGrade =
                        _database.Grades.FirstOrDefault(g => g.CourseId == course.CourseId && g.UserId == _currentUser.Id);

                    CourseQuizGrade? userQuizGrade = _database.CourseQuizGrades.FirstOrDefault(cg =>
                        cg.CourseId == course.CourseId && cg.UserId == _currentUser.Id);
                    
                    totalCoefficientPoints += course.Value;

                    if (userCourseGrade != null && userCourseGrade.InterestScore != -1 && userCourseGrade.FinalGrade != -1)
                    {
                        totalActualGrade += ((double)(userCourseGrade.FinalGrade))/10 * course.Value;
                        totalInterestScore += ((double)(userCourseGrade.InterestScore))/5 * course.Value;
                    }

                    if (userQuizGrade != null)
                    {
                        totalQuizGradeScore += ((double)userQuizGrade.Grade) / 100 * course.Value;
                    }
                }
                
                totalActualGrade = 100 * totalActualGrade / totalCoefficientPoints;
                totalInterestScore = 100 * totalInterestScore / totalCoefficientPoints;
                totalQuizGradeScore = 100 * totalQuizGradeScore / totalCoefficientPoints;

                if (double.IsNaN(totalActualGrade))
                    totalActualGrade = 0f;

                if (double.IsNaN(totalInterestScore))
                    totalInterestScore = 0f;
                
                if (double.IsNaN(totalQuizGradeScore))
                    totalQuizGradeScore = 0f;
                
                var userEvaluationTest = _database.CoefficientQuizGrades.OrderByDescending(t => t.Grade).FirstOrDefault(t => t.UserId == _currentUser.Id && t.CoefficientName == coefficient.Name);
                if (userEvaluationTest == null)
                {
                    totalQuizGradeScore /= 2;
                }
                else
                {
                    totalQuizGradeScore = (totalQuizGradeScore + userEvaluationTest.Grade) / 2;
                }
                
                
                var userHasPercentage = _database.UserHasCoefficients.FirstOrDefault(u => u.UserId == _currentUser.Id && u.CoefficientName == coefficient.Name);

                if (userHasPercentage != null)
                {
                    CoefficientGeneralDictionary.Add(coefficient, userHasPercentage.Percentage);
                }
                else
                {
                    CoefficientGeneralDictionary.Add(coefficient, 0f);
                }
                
                CoefficientActualGradeDictionary.Add(coefficient, totalActualGrade);
                CoefficientInterestScoreDictionary.Add(coefficient, totalInterestScore);
                CoefficientQuizScoreDictionary.Add(coefficient, totalQuizGradeScore);
            }
            
            var model = new Tuple<Dictionary<Coefficient, double>, Dictionary<Coefficient, double>, Dictionary<Coefficient, double>, Dictionary<Coefficient, double>>(
                CoefficientActualGradeDictionary, CoefficientQuizScoreDictionary, CoefficientInterestScoreDictionary, CoefficientGeneralDictionary);
            return View(model);
        }

        public IActionResult Suggestions()
        {
            // retrieve the top three coefficients of the user
            var userBestCoefficients = _database.UserHasCoefficients.Where(p => p.UserId == _currentUser.Id).ToList().OrderByDescending(uhc => uhc.Percentage).Take(3).ToArray();

            // if the user has no coefficients, return empty lists.
            if (userBestCoefficients.Length == 0)
            {
                var emptyCareerList = new List<Career>();
                var emptyPgiList = new List<PostGraduateInstitution>();
                Coefficient coefficient = _database.Coefficients.First();

                var emptyTuple = new Tuple<List<Career>, List<PostGraduateInstitution>, Coefficient>(emptyCareerList, emptyPgiList, coefficient);
                return View(emptyTuple);
            }
            
            // retrieve the post graduate institutions based on the top coefficient of the user
            var bestPostGraduateIds = _database.PostGraduateInstitutionHasCoefficients.ToList().Where(pgic =>
                pgic.CoefficientName == userBestCoefficients[0].CoefficientName);

            var bestPostGraduates = (from pgic in bestPostGraduateIds
                join pgi in _database.PostGraduateInstitutions.ToList() on pgic.PostGraduateInstitutionId equals pgi.Id
                select pgi).ToList();

            // retrieve the careers based on the top coefficient of the user.
            var userBestCoefficient = _database.Coefficients.First(c => c.Name == userBestCoefficients[0].CoefficientName);
            var careers = (from career in _database.Careers.ToList() where career.CoefficientName == userBestCoefficients[0].CoefficientName select career).ToList();

            // put it in the model and show it.
            var model = new Tuple<List<Career>, List<PostGraduateInstitution>, Coefficient>(careers, bestPostGraduates, userBestCoefficient);
            return View(model);
        }
        
    }
}
