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
    public bool SoftwareEngineering { get; set; } = false;

    [Required] 
    public bool AI_ML { get; set; } = false;

    [Required] 
    public bool UI_UX { get; set; } = false;

    [Required] 
    public bool Security { get; set; } = false;

    [Required] 
    public bool ComputerNetworks { get; set; } = false;

    [Required] 
    public bool ComputerVisionAndGraphics { get; set; } = false;

    [Required] 
    public bool GameDev { get; set; } = false;

    [Required] 
    public bool DatabaseEngineering { get; set; } = false;

    [Required] 
    public bool WebDev { get; set; } = false;

    [Required] 
    public bool MobileAppDev { get; set; } = false;

}