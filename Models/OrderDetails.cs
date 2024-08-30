using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAdmin.Models;

public class OrderDetails
{
    public int Id { get; set; }
    public int IdOrdered { get; set; }
    public int IdProduct { get; set; }
    public int Quantity { get; set; }
    public double UnitPrice { get; set; }

}
