using Microsoft.EntityFrameworkCore;

namespace TaskManagementSystem.Model;

public class TaskManagementDB : DbContext
{
    public DbSet<Category> Category { get; set; }
    public DbSet<TaskItem> TaskItem { get; set; }
    public DbSet<User> User { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=.; Database=TaskManagementDB; Trusted_Connection=True; Encrypt=False;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Study" },
            new Category { Id = 2, Name = "Entertainment" },
            new Category { Id = 3, Name = "Work" },
            new Category { Id = 4, Name = "Travel" }
        );
    }
}