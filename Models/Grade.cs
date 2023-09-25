﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace EduCompass.Models;

public class Grade
{
    // PRIMARY KEY
    [Key]
    public int Id { get; set; }
    
    [ForeignKey("User")]
    public int UserId { get; set; }
    
    [ForeignKey("Course")]
    public int CourseId { get; set; }

    public int FinalGrade { get; set; } = -1;

    public int InterestScore { get; set; } = -1;

    public DateTime Created { get; set; } = DateTime.Now;
}