using JobApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace JobApplication.Models
{
    
        public class DataContext : DbContext
        {
            public DataContext(DbContextOptions options) : base(options)
            {
                Database.EnsureCreated();
            }
            public DbSet<Class> Classs { get; set; }
        }
    }


