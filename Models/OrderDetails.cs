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
    public int IdOrdered { get; set; }

    [Column("id_product")] 
    public int IdProduct { get; set; }

    [Column("quantity")]
    public int Quantity { get; set; }

    [Column("unit_price")]
    public double UnitPrice { get; set; }

}
