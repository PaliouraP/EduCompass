using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace EduCompass.Models;

public class Grade
{
    // PRIMARY KEY
    [Key]
    public int Id { get; set; }
    
    [ForeignKey("User"), NotNull]
    public int UserId { get; set; }
    
    [ForeignKey("Course"), NotNull]
    public int CourseUUID { get; set; }
    
    public int FinalGrade { get; set; }
    
    public int InterestScore { get; set; }
    
    public DateTime Created { get; set; } = DateTime.Now;
    
    // Navigation Properties
    public virtual User _User { get; set; }
    
    public virtual Course _Course { get; set; }
    
}