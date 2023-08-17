using System.ComponentModel.DataAnnotations;

namespace EduCompass.Models;

public class Course
{
    // PRIMARY KEY
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    public int Semester { get; set; }
    
    [Required]
    public int Year { get; set; }
    
    public string Description { get; set; }

    public bool InIntro { get; set; } = false;
    
    // COEFFICIENTS
    [Required]
    public int SoftwareProgramming { get; set; }
    
    [Required]
    public int SoftwareEngineering { get; set; }
    
    [Required]
    public int AI_ML { get; set; }
    
    [Required]
    public int ProjectManagement { get; set; }
    
    [Required]
    public int WebDev { get; set; }
    
    [Required]
    public int Security { get; set; }
    
    [Required]
    public int CloudArchitect { get; set; }
    
    [Required]
    public int UI_UX { get; set; }
}