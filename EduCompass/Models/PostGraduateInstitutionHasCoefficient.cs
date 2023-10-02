using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EduCompass.Models;

[PrimaryKey(nameof(PostGraduateInstitutionId), nameof(CoefficientName))]
public class PostGraduateInstitutionHasCoefficient
{
    [ForeignKey("PostGraduateInstitution")]
    public int PostGraduateInstitutionId { get; set; }
    
    [ForeignKey("Coefficient")]
    public string CoefficientName { get; set; }

    public bool HasCoefficient { get; set; } = false;
}