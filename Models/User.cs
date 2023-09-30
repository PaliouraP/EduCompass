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
                    
                    if (quizGrade != null)
                    {
                        userTotalCoefficientPoints += ((double)quizGrade.Grade / 100) * (double)(0.5 * (double)course.Value);
                    }
                    else
                    {
                        userTotalCoefficientPoints += 0f;
                    }

                    if (introGrade != null && introGrade.FinalGrade != -1 && introGrade.InterestScore != -1)
                    {
                        userTotalCoefficientPoints += ((double)introGrade.FinalGrade / 10) * (double)(0.3 * (double)course.Value);
                        userTotalCoefficientPoints += ((double)introGrade.InterestScore / 5) * (double)(0.2 * (double)course.Value);
                    }
                    else
                    {
                        userTotalCoefficientPoints += 0f;
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
