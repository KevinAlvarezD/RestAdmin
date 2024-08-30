using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestAdmin.Models;

[Table("products")]
public class Product
{
    [Key]
    [Column("id")]
    [MaxLength(11, ErrorMessage = "The field must be at most {1} character.")]
    public int Id { get; set; }

    [Key]
    [Column("image_url")]
    [MaxLength(255, ErrorMessage = "The field must be at most {1} character.")]
    public string? ImageURL { get; set; }

    [Column("name")]
    [MaxLength(50, ErrorMessage = "The field must be at most {1} character.")]
    public string? Name { get; set; }

    [Column("description")]
    [MaxLength(255, ErrorMessage = "The field must be at most {1} character.")]
    public string? Description { get; set; }

    [Column("price")]
    [MaxLength(20, ErrorMessage = "The field must be at most {1} character.")]
    public double Price { get; set; }

}
