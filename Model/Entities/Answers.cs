using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Model.Entities;
[Table("ANSWERS")]
public class Answers
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ANSWER_ID")]
    public int Id { get; set; }
    
    
    [Column("ANSWER_TEXT")]
    public string AnswerText { get; set; }
    
    [Column("ISCORRECT")]
    public bool IsCorrect { get; set; }
    
    [Column("QUESTION_ID")]
    public int QuestionId { get; set; }
    public Questions Question { get; set; }
}