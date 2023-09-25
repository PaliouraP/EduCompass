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
        
    }
}
