using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestAdmin.Models;


[Table("invoices")]
public class Invoice
{
    [Key]
    [Column("id_invoice")]
    [MaxLength(11, ErrorMessage = "The field must be at most {1} character.")]
    public int IdInvoice { get; set; }

    [Column("id_order")]
    [MaxLength(11, ErrorMessage = "The field must be at most {1} character.")]
    public int IdOrder { get; set; }

    [Column("date_invoice")]
    [MaxLength(70, ErrorMessage = "The field must be at most {1} character.")]
    public DateTime DateInvoice { get; set; }

    [Column("total")]
    [MaxLength(20, ErrorMessage = "The field must be at most {1} character.")]
    public double Total { get; set; }

}