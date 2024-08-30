using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestAdmin.Models;

[Table("ordereds")]
public class Ordered
{
    [Key]
    [Column("id")]
    [MaxLength(11, ErrorMessage = "The field must be at most {1} character.")]
    public int Id { get; set; }

    [Column("name")]
    [MaxLength(50, ErrorMessage = "The field must be at most {1} character.")]
    public string? Name { get; set; }

    [Column("id_customer")]
    [MaxLength(11, ErrorMessage = "The field must be at most {1} character.")]
    public int IdCustomer { get; set; }

    [Column("id_table")]
    [MaxLength(11, ErrorMessage = "The field must be at most {1} character.")]
    public int IdTable { get; set; }

    [Column("employee")]
    [MaxLength(11, ErrorMessage = "The field must be at most {1} character.")]
    public int Employee { get; set; }
}
