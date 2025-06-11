using Microsoft.EntityFrameworkCore;
using Task_1_mvc.Models;

namespace Task_1_mvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=.;Database=TaskMvc;TrustServerCertificate=True;Trusted_Connection=True");
        }
    }
}
