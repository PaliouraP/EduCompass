using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EduCompass.Models;

[PrimaryKey(nameof(BaseCourseId), nameof(PrerequisiteCourseId))]
public class PrerequisiteCourse
{
    [Required]
    public int BaseCourseId { get; set; }
    
    [Required]
    public int PrerequisiteCourseId { get; set; }
}