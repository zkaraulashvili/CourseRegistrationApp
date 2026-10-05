using Microsoft.EntityFrameworkCore;

namespace CourseRegistrationApp.Models;

public class ApplicationContext : DbContext
{
    public DbSet<CourseRegistration> CourseRegistrations { get; set; } = null!;

    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
}