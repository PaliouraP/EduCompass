using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace EduCompass.Models;

[PrimaryKey(nameof(UserId), nameof(CourseId))]
public class Grade
{
    [ForeignKey("User")]
    public int UserId { get; set; }
    
    [ForeignKey("Course")]
    public int CourseId { get; set; }

    public int FinalGrade { get; set; }

    public int InterestScore { get; set; }

    public DateTime Created { get; set; } = DateTime.Now;
}