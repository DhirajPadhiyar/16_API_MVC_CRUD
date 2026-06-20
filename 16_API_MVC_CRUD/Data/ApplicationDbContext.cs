using _16_API_MVC_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace _16_API_MVC_CRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(s => s.Name)
                .IsRequired();

            modelBuilder.Entity<Student>()
                .Property(s => s.City)
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
