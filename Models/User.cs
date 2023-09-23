using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public int Semester { get; set; }

        public bool HasCompletedIntroTest { get; set; } = false;

        //public string Track { get; set; } = string.Empty;

        public DateTime Created { get; set; } = DateTime.Now;
        
        // COEFFICIENTS
        [Required]
        public float SoftwareEngineerPercentage { get; set; } = 0f;
        
        [Required]
        public float AI_ML_Percentage { get; set; } = 0f;
        
        [Required]
        public float UI_UX_Percentage { get; set; } = 0f;
        
        [Required]
        public float SecurityPercentage { get; set; } = 0f;
        
        [Required]
        public float ComputerNetworksPercentage { get; set; } = 0f;
        
        [Required]
        public float ComputerVisionAndGraphicsPercentage { get; set; } = 0f;

        [Required] 
        public float GameDevPercentage { get; set; } = 0f;

        [Required] 
        public float DatabaseEngineeringPercentage { get; set; } = 0f;

        [Required]
        public float WebDevPercentage { get; set; } = 0f;

        [Required] 
        public float MobileAppDevPercentage { get; set; } = 0f;
        
        // CALCULATING COEFFICIENTS
        public static float SoftwareEngineeringTotal(List<Course> courses, List<Grade> grades, User user)
        {
            var coursesAndGradesWithSoftwareEngineeringPoints = (from grade in grades
                where grade.UserId == user.Id && grade.FinalGrade != -1 && grade.InterestScore != -1
                join course in courses on grade.CourseUUID equals course.UUID
                select (course, grade)).ToList();

            int totalSoftwareEngineeringPoints = coursesAndGradesWithSoftwareEngineeringPoints.Sum(c => c.Item1.SoftwareEngineering);
            float userSum = 0;
            
            foreach (var courseAndGrade in coursesAndGradesWithSoftwareEngineeringPoints)
            {
                int courseCoefficient = courseAndGrade.Item1.SoftwareEngineering;

                float fromGradesTotal = (float)(courseCoefficient * (float)courseAndGrade.Item2.FinalGrade / 10 * 0.7 + courseCoefficient * (float)courseAndGrade.Item2.InterestScore/5 * 0.3);
                userSum += fromGradesTotal;
            }
            
            return userSum/totalSoftwareEngineeringPoints;
        }
    }
}
