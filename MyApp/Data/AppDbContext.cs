using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().Property(u => u.Age)
                .HasComputedColumnSql("DATEDIFF(Year,Birthdate,GETDATE())");
            base.OnModelCreating(builder);
        }
    }
}