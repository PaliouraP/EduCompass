using EduCompass.Data;
using EduCompass.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EduCompass.Controllers
{
    public class CourseController : Controller
    {
        private ILogger<CourseController> _logger;
        private ApplicationDbContext _database;
        private User? _currentUser;

        public CourseController(ILogger<CourseController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _database = db;
        }
        
        /// <summary>
        /// This method gets executed before any view is rendered.
        /// <b>Before any action runs, we want to ensure that the user's session hasn't expired. If it has, we log the user out</b>
        /// </summary>
        /// <param name="context">The context responsible for redirecting to the correct page.</param>
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

        public IActionResult OrientationPage()
        {
            // COEFFICIENTS WITH PASSED LESSONS.
            var coefficientsWithCompletedCourses = new Dictionary<Coefficient, string>();

            // take all coefficients
            foreach (var coefficient in _database.Coefficients.ToArray())
            {
                // start with zero passed courses.
                int completedCoursesInCoefficient = 0;
                int coursesInCoefficient = 0;
                
                // and for every course in the database
                foreach (var course in _database.Courses.ToArray())
                {
                    // see if there is this coefficient present in it.
                    if (!_database.CourseHasCoefficients.Any(chc =>
                            chc.CoefficientName == coefficient.Name && chc.CourseId == course.Id && chc.Value > 0))
                        continue;

                    coursesInCoefficient++;
                    
                    // see also if the quiz grade is above 50%
                    if (!_database.CourseQuizGrades.Any(cqg => cqg.Grade >= 50 && cqg.CourseId == course.Id && cqg.UserId == _currentUser.Id))
                        continue;

                    // and if all of the above are true, this course is passed in this coefficient.
                    completedCoursesInCoefficient++;
                }
                
                // add this value in the dictionary.
                coefficientsWithCompletedCourses.Add(coefficient, $"{completedCoursesInCoefficient}/{coursesInCoefficient}");
            }

            // LOCKED COURSES.
            var lockedCourses = new Dictionary<Course, bool>();
            foreach (var course in _database.Courses.ToArray())
            {
                // start at false
                var locked = false;
                
                // get all of the prerequisite courses of this course
                var thisCoursesPrerequisites =
                    _database.PrerequisiteCourses.Where(pc => pc.BaseCourseId == course.Id).ToArray();
                
                if (thisCoursesPrerequisites.Length == 0)
                    lockedCourses.Add(course, locked);
                
                // search all prerequisite courses of this one
                foreach (var prerequisiteCourse in thisCoursesPrerequisites)
                {
                    // if the user hasn't yet done a quiz, in any of the prerequisite courses, lock the course.
                    if (!_database.CourseQuizGrades.Any(g =>
                            g.CourseId == prerequisiteCourse.PrerequisiteCourseId && g.UserId == _currentUser.Id))
                    {
                        locked = true;
                    }

                    // and see if any of them has a grade of 50. If NONE has a grade above 50, then lock it.
                    if (_database.CourseQuizGrades.All(g =>
                            g.CourseId == prerequisiteCourse.PrerequisiteCourseId && g.Grade < 50 && g.UserId == _currentUser.Id))
                    {
                        locked = true;
                    }
                    
                    lockedCourses.Add(course, locked);
                }
            }
            
            // COURSE GRADES
            var coursesWithTheirGrades = new Dictionary<Course, int>();
            foreach (var course in _database.Courses.ToArray())
            {
                // start with an initial value of 0.
                int grade = 0;
                
                // get the maximum grade of a quiz...
                var maxGrade = _database.CourseQuizGrades.OrderBy(t => t.Grade).LastOrDefault(t => t.CourseId == course.Id && t.UserId == _currentUser.Id);
                
                // ...if the quiz exists.
                if (maxGrade != null)
                    grade = maxGrade.Grade;
                
                coursesWithTheirGrades.Add(course, grade);
            }
            
            // COEFFICIENTS WITH THEIR COURSES.
            var coefficientsWithTheirCourses = new Dictionary<Coefficient, List<Course>>();
            foreach (var coefficient in _database.Coefficients.ToArray())
            {
                var coursesInThisCoefficient = new List<Course>();
                
                foreach (var course in _database.Courses.ToArray())
                {
                    if (!_database.CourseHasCoefficients.Any(chc =>
                               chc.CoefficientName == coefficient.Name && chc.CourseId == course.Id && chc.Value > 0))
                        continue;
                    
                    coursesInThisCoefficient.Add(course);
                }
                
                coefficientsWithTheirCourses.Add(coefficient, coursesInThisCoefficient.OrderBy(c => c.Semester).ToList());
            }
            
            // COEFFICIENTS WITH THEIR GRADES.
            var coefficientsWithTheirGrades = new Dictionary<Coefficient, string>();
            foreach(var coefficient in _database.Coefficients.ToArray())
            {
                string gradeString;
                
                CoefficientQuizGrade grade = _database.CoefficientQuizGrades.OrderBy(quiz => quiz.Grade).LastOrDefault(quiz => quiz.CoefficientName == coefficient.Name && quiz.UserId == _currentUser.Id);

                gradeString = grade == null ? "-" : $"{grade.Grade}%";
                coefficientsWithTheirGrades.Add(coefficient, gradeString);
            }

            // return all these to the model.
            var model = new Tuple<Dictionary<Coefficient, string>, Dictionary<Course, bool>, Dictionary<Course, int>, Dictionary<Coefficient, List<Course>>, Dictionary<Coefficient, string>>(coefficientsWithCompletedCourses, lockedCourses, coursesWithTheirGrades, coefficientsWithTheirCourses, coefficientsWithTheirGrades);
            return View(model);
        }
        
        [HttpGet]
        public IActionResult CoursePage(string uuid)
        {
            // get the course.
            var course = _database.Courses.First(c => c.UUID == uuid);

            var locked = true;

            // prerequisite courses.
            var necessaryCourseIds = _database.PrerequisiteCourses.Where(p => p.BaseCourseId == course.Id).ToList();
            var necessaryCourses = (from pc in necessaryCourseIds join _course in _database.Courses on pc.PrerequisiteCourseId equals _course.Id select _course).ToList();

            foreach (var necessaryCourse in necessaryCourseIds)
            {
                if (_database.CourseQuizGrades.Any(c =>
                        c.Grade >= 50 && c.CourseId == necessaryCourse.PrerequisiteCourseId &&
                        c.UserId == _currentUser.Id))
                    locked = false;
            }
            
            // coefficients related to a career
            var baseCourseCoefficients = _database.CourseHasCoefficients.Where(chc => chc.Value > 5 && chc.CourseId == course.Id).ToList();
            var careers = (from chc in baseCourseCoefficients
                join career in _database.Careers on chc.CoefficientName equals career.CoefficientName
                select career).ToList();

            var model = new Tuple<Course, List<Course>, List<Career>, bool>(course, necessaryCourses, careers, locked);
            
            return View(model);
        }
    }
}
