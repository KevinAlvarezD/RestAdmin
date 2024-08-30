using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RestAdmin.Models;

[Table("order_details")]
public class OrderDetails
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    [Column("id_ordered")]
    [MaxLength(11, ErrorMessage = "The Name field must be at most {1} characters.")]
    public int IdOrdered { get; set; }
    [Column("id_product")]
    [MaxLength(11, ErrorMessage = "The Name field must be at most {1} characters.")]
    public int IdProduct { get; set; }
    [Column("quantity")]
    [MaxLength(11, ErrorMessage = "The Name field must be at most {1} characters.")]
    public int Quantity { get; set; }
    [Column("unit_price")]
    [MaxLength(11, ErrorMessage = "The Name field must be at most {1} characters.")]
    public double UnitPrice { get; set; }

}
