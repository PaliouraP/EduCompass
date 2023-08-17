﻿using System.ComponentModel.DataAnnotations;

namespace EduCompass.Models;

public class Course
{
    // PRIMARY KEY
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    public int Semester { get; set; }
    
    [Required]
    public int Year { get; set; }
    
    public string Description { get; set; }

    public bool InIntro { get; set; } = false;
}