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
    public int IdInvoice { get; set; }

    [Column("id_order")]
    public int IdOrder { get; set; }

    [Column("date_invoice")]
    [DataType(DataType.Date)]
    public DateTime DateInvoice { get; set; }

    [Column("total")]
    public double Total { get; set; }

}