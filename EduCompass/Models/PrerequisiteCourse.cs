using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EduCompass.Models;

[PrimaryKey(nameof(BaseCourseId), nameof(PrerequisiteCourseId))]
public class PrerequisiteCourse
{
    [Required]
    [ForeignKey("Course")]
    public int BaseCourseId { get; set; }
    
    [Required]
    [ForeignKey("Course")]
    public int PrerequisiteCourseId { get; set; }
}