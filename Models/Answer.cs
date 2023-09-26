using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using Microsoft.IdentityModel.Tokens;

namespace EduCompass.Models;

public class Answer
{
    [Key]
    public int Id { get; set; }
    
    [ForeignKey("Question")]
    public int QuestionId { get; set; }
    
    [NotNull]
    public string Answer1 { get; set; } = string.Empty;
    
    [AllowNull]
    public string Answer2 { get; set; }
    
    [AllowNull]
    public string Answer3 { get; set; }
    
    [AllowNull]
    public string Answer4 { get; set; }
    
    [NotNull]
    public string CorrectAnswer { get; set; } = string.Empty;
    
    // method to find the QuestionType
    public QuestionType GetQuestionType()
    {
        if (Answer2.IsNullOrEmpty())
            return QuestionType.FillTheBlank;
        
        if (Answer3.IsNullOrEmpty())
            return QuestionType.TrueOrFalse;

        return QuestionType.MultipleChoice;
    }
}

public enum QuestionType
{
    TrueOrFalse = 1,
    FillTheBlank = 2,
    MultipleChoice = 3
}