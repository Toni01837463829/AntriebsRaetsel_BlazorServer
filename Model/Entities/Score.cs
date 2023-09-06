using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("SCORES")]
public class Scores
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("QUESTION_ID")]
    public int Question_Id { get; set; }


    [Column("PLAYER_NAME"), Required]
    public string PlayerName { get; set; }
    
    [Column("SCORE"), Required]
    public int Score { get; set; }
}