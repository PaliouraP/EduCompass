using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduCompass.Models;

public class CourseQuizGrade
{
    [Key]
    public int Id { get; set; }
    
    [ForeignKey("User")]
    public int UserId { get; set; }
    
    [ForeignKey("Course")]
    public int CourseId { get; set; }
    
    public DateTime TimeStarted { get; set; }
    
    public DateTime TimeFinished { get; set; }
    
    public int Grade { get; set; }
}