using Microsoft.EntityFrameworkCore;
using TaskApp.Domain;

namespace TaskApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<WorkTask> Tasks { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WorkTask>()
                .HasIndex(t => t.Title)
                .IsUnique();
        }
    }
}