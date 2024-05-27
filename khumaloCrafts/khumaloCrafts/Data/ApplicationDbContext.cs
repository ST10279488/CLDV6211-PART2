using khumaloCrafts.Models;
using Microsoft.EntityFrameworkCore;

namespace khumaloCrafts.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
    }

    public DbSet<Order> Orders { get; set; }
}
}
   
