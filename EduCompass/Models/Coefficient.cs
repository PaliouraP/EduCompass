using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduCompass.Models;

public class Coefficient
{
    [Key] 
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string Name { get; set; } = string.Empty;

    [Required]
    public string NameInGreek { get; set; } = string.Empty;
}