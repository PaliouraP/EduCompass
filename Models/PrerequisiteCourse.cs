using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EduCompass.Models;

[PrimaryKey(nameof(BaseCourseUUID), nameof(PrerequisiteCourseUUID))]
public class PrerequisiteCourse
{
    [Required]
    public string BaseCourseUUID { get; set; }
    
    [Required]
    public string PrerequisiteCourseUUID { get; set; }
}