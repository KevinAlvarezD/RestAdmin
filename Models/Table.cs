using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RestAdmin.Models;
[Table("tables")]

public class Table
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    [Column("table_number")]
    [MaxLength(255, ErrorMessage = "The Name field must be at most {1} characters.")]
    public string? TableNumber { get; set; }
    [Column("capacity")]
    [MaxLength(11, ErrorMessage = "The Name field must be at most {1} characters.")]
    public int Capacity { get; set; }

}
