using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestAdmin.Models;

[Table("payments")]
public class Payment
{
    [Key]
    [Column("id")]

    public int IdPayment { get; set; }
    [Column("id_invoice")]
    [MaxLength(11, ErrorMessage = "The Name field must be at most {1} characters.")]
    public int IdInvoice { get; set; }
    [Column("date_payment")]
    [DataType(DataType.Date)]
    public DateTime DatePayment { get; set; }
    [Column("amount")]
    [MaxLength(11, ErrorMessage = "The Name field must be at most {1} characters.")]
    public double Amount { get; set; }
    [Column("payment_method")]
    [MaxLength(255, ErrorMessage = "The Name field must be at most {1} characters.")]
    public string? PaymentMethod { get; set; }
}
