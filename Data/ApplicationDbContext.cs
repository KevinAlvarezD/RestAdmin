
using Microsoft.EntityFrameworkCore;
using RestAdmin.Models;

namespace LibrarySystem.Data;
public class ApplicationDbContext : DbContext
{
   public DbSet<Product> Products { get; set; }
   
   public DbSet<Customer> Customers { get; set; }

   public DbSet<Table> Tables { get; set; }

   public DbSet<Employee> Employees { get; set; }





   public DbSet<Payment> Payments { get; set; }
   
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }

}