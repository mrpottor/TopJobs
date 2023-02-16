using Employer.Models;
using Microsoft.EntityFrameworkCore;

namespace JobSeeker
{
    public class DataContext:DbContext
    {
            public DataContext(DbContextOptions options) : base(options)
            {
                Database.EnsureCreated();
            }
            public DbSet<JobSeekerRegistration> JobSeekerRegistrations { get; set; }
        }
}
