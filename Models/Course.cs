using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduCompass.Models;

public class Course
{
    // PRIMARY KEY
    [Key] 
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required]
    public string UUID { get; set; } = string.Empty;
    
    [Required]
    public string Name { get; set; } = string.Empty;
    
    [Required]
    public int Semester { get; set; }

    [Required]
    public string Description { get; set; } = string.Empty;

    [Required]
    public string Content { get; set; } = string.Empty;

    [Required] 
    public string AudioFileName { get; set; } = string.Empty;
    
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
    public int DatabaseEngineering { get; set; } = 0;
    
    [Required] 
    public int WebDev { get; set; } = 0;
    
    [Required] 
    public int MobileAppDev { get; set; } = 0;
}