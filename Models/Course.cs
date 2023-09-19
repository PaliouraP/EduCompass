using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduCompass.Models;

public class Course
{
    // PRIMARY KEY
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string UUID { get; set; } = string.Empty;
    
    [Required]
    public string Name { get; set; } = string.Empty;
    
    [Required]
    public int Semester { get; set; }
    
    [Required]
    public int Year { get; set; }
    
    public string Description { get; set; } = string.Empty;

    public bool InIntro { get; set; } = false;

    public CourseType[] Type { get; set; } = { CourseType.None };
    
    // COEFFICIENTS
    [Required] 
    public int SoftwareEngineering { get; set; } = 0;
    
    [Required] 
    public int AI_ML { get; set; } = 0;
    
    [Required] 
    public int UI_UX { get; set; } = 0;
    
    [Required] 
    public int Security { get; set; } = 0;
    
    [Required] 
    public int ComputerNetworks { get; set; } = 0;
    
    [Required] 
    public int ComputerVisionAndGraphics { get; set; } = 0;
    
    [Required] 
    public int GameDev { get; set; } = 0;
    
    [Required] 
    public int DatabaseManagement { get; set; } = 0;
    
    [Required] 
    public int WebDev { get; set; } = 0;
    
    [Required] 
    public int MobileAppDev { get; set; } = 0;
}

public enum CourseType
{
    None,
    TLES,
    PSY,
    DYS,
    Optional
}