using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAdmin.Models;

public class Ordered
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int IdCostumer { get; set; }
    public int IdTable { get; set; }
    public int Employee { get; set; }

}
