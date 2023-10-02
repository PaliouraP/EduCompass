using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace EduCompass.Models;

public class Question
{
    [Key]
    public int Id { get; set; }

    [NotNull]
    public string Content { get; set; } = string.Empty;
    
    [ForeignKey("Course")]
    public int CourseId { get; set; }
}