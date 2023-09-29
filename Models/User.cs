using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EduCompass.Data;

namespace EduCompass.Models
{
    public class User
    {
        // PRIMARY KEY
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        
        public bool HasCompletedIntroTest { get; set; } = false;

        public DateTime Created { get; set; } = DateTime.Now;

        public void CalculateUserCoefficients(ApplicationDbContext db)
        {
            var allCoefficients = db.Coefficients.ToArray();

            foreach (var coefficient in allCoefficients)
            {
                var coursesWithThisCoefficient =
                    db.CourseHasCoefficients.Where(chc => chc.CoefficientName == coefficient.Name).ToArray();
                
                double totalCoefficientPoints = 0f;
                double userTotalCoefficientPoints = 0f;
                double userPercentage = 0f;
                
                foreach (var course in coursesWithThisCoefficient)
                {
                    CourseQuizGrade? quizGrade = db.CourseQuizGrades.Where(q => q.UserId == this.Id && q.CourseId == course.CourseId).OrderByDescending(q => q.Grade).FirstOrDefault();
                    Grade? introGrade = db.Grades.FirstOrDefault(g => g.CourseId == course.CourseId && g.UserId == this.Id);

                    totalCoefficientPoints += course.Value;
                    
                    if (quizGrade != null && introGrade != null)
                    {
                        userTotalCoefficientPoints += (double)quizGrade.Grade / 100 * 0.5 * course.Value;
                        userTotalCoefficientPoints += (double)introGrade.FinalGrade / 10 * 0.3 * course.Value;
                        userTotalCoefficientPoints += (double)introGrade.InterestScore / 5 * 0.2 * course.Value;
                    }
                    
                    else if (quizGrade == null && introGrade != null)
                    {
                        userTotalCoefficientPoints += (double)introGrade.FinalGrade / 10 * 0.7 * course.Value;
                        userTotalCoefficientPoints += (double)introGrade.InterestScore / 5 * 0.3 * course.Value;
                    }
                    
                    else if (quizGrade != null && introGrade == null)
                    {
                        userTotalCoefficientPoints += (double)quizGrade.Grade / 100 * course.Value;
                    }
                }
                
                userPercentage = 100 * userTotalCoefficientPoints / totalCoefficientPoints;

                if (double.IsNaN(userPercentage) || userPercentage == 0)
                    continue;
                
                var userCoefficient = db.UserHasCoefficients.FirstOrDefault(uhc => uhc.CoefficientName == coefficient.Name && uhc.UserId == this.Id);

                if (userCoefficient == null)
                {
                    UserHasCoefficient userHasCoefficient = new UserHasCoefficient
                    {
                        CoefficientName = coefficient.Name,
                        Percentage = userPercentage,
                        UserId = this.Id
                    };

                    db.UserHasCoefficients.Add(userHasCoefficient);
                    db.SaveChanges();
                }
                else
                {
                    userCoefficient.Percentage = userPercentage;
                    db.UserHasCoefficients.Update(userCoefficient);
                    db.SaveChanges();
                }
            }

        }

    }
}
