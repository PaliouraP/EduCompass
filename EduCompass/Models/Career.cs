using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduCompass.Models;

public class Career
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string Name { get; set; } = string.Empty;

    [ForeignKey("Coefficient")] 
    public string CoefficientName { get; set; } = string.Empty;
    
    public string NameInGreek { get; set; } = string.Empty;
}