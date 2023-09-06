using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;
[Table("QUESTIONS")]
public class Questions
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("QUESTION_ID")]
    public int Id { get; set; }

    [StringLength(45)]
    [Column("QUESTION_TEXT")]
    public string QuestionText { get; set; }


}