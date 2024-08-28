
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

}