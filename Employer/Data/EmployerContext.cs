using System.Threading.Tasks;
using Employer.Models;
using Microsoft.EntityFrameworkCore;

namespace Employer.Data
{
    public class EmployerContext:DbContext
    {
        public EmployerContext(DbContextOptions<EmployerContext> options)
            : base(options)
        { }

        public DbSet<Recruiter> recruiters { get; set; }
    }
}
