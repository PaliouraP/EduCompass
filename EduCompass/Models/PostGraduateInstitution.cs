using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduCompass.Models;

public class PostGraduateInstitution
{
    // PRIMARY KEY
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required] 
    public string Name { get; set; } = string.Empty;

    [Required]
    public string Department { get; set; } = string.Empty;

    [Required]
    public string Town { get; set; } = string.Empty;
    
    [Required]
    public string Hyperlink { get; set; } = string.Empty;

    [Required] 
    public string Description { get; set; } = string.Empty;
}