using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EduCompass.Models;

[PrimaryKey(nameof(UserId), nameof(CoefficientName))]
public class UserHasCoefficient
{
    [ForeignKey("User")]
    public int UserId { get; set; }
    
    [ForeignKey("Coefficient")]
    public string CoefficientName { get; set; }

    public double Percentage { get; set; } = 0f;
}