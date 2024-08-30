using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAdmin.Models;

public class Invoice
{
    public int IdInvoice { get; set; }
    public int IdOrder { get; set; }
    public DateTime DateInvoice { get; set; }
    public double Total { get; set; }

}