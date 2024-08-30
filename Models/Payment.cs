using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAdmin.Models;

public class Payment
{
    public int IdPayment { get; set; }
    public int IdInvoice { get; set; }
    public DateTime DatePayment { get; set; }
    public double Amount { get; set; }
    public string? PaymentMethod { get; set; }
}
