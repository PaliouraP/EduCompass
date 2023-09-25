using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EduCompass.Models;

[PrimaryKey(nameof(CourseId), nameof(CoefficientName))]
public class CourseHasCoefficient
{
    [ForeignKey("Course")]
    public int CourseId { get; set; }
    
    [ForeignKey("Coefficient")]
    public string CoefficientName { get; set; }

    public int Value { get; set; }
}