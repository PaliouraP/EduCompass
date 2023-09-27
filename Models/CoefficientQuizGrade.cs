using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduCompass.Models;

public class CoefficientQuizGrade
{
    [Key]
    public int Id { get; set; }
    
    [ForeignKey("User")]
    public int UserId { get; set; }

    [ForeignKey("Coefficient")]
    public string CoefficientName;
    
    public DateTime TimeStarted { get; set; }
    
    public DateTime TimeFinished { get; set; }
    
    public string QuestionIds { get; set; }
    
    public string AnswerStrings { get; set; }
    
    public int Grade { get; set; }
}