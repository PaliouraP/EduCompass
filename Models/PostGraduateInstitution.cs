using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduCompass.Models;

public class PostGraduateInstitution
{
    // PRIMARY KEY
    [Key]
    public int Id { get; set; }

    [Required] 
    public string Name { get; set; } = string.Empty;

    [Required]
    public string Department { get; set; } = string.Empty;
    
    [Required]
    public string Country { get; set; } = string.Empty;
    
    [Required]
    public string Town { get; set; } = string.Empty;
    
    // COEFFICIENTS
    [Required]
    public bool SoftwareProgramming { get; set; } = false;

    [Required] 
    public bool SoftwareEngineering { get; set; } = false;

    [Required] 
    public bool AI_ML { get; set; } = false;

    [Required] 
    public bool ProjectManagement { get; set; } = false;

    [Required] 
    public bool WebDev { get; set; } = false;

    [Required] 
    public bool Security { get; set; } = false;

    [Required] 
    public bool CloudArchitect { get; set; } = false;

    [Required] 
    public bool UI_UX { get; set; } = false;

}