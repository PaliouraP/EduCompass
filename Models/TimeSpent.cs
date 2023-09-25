using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduCompass.Models;

public class TimeSpent
{
    [Key]
    public int Id { get; set; }
    
    [ForeignKey("User")]
    public int UserId { get; set; }
    
    [ForeignKey("Course")]
    public int CourseId { get; set; }
    
    public int TotalTime { get; set; }
}