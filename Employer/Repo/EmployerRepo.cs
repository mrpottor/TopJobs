using Microsoft.EntityFrameworkCore;
using Employer.Models;
using Microsoft.AspNetCore.Mvc;
using Employer.Data;

namespace Employer.Repo
{
    public class EmployerRepo : IEmployerRepo
    {
        private readonly EmployerContext _context;
        public EmployerRepo(EmployerContext context)
        {
            _context = context;
        }

        public Task DeleteEmployer(int employerId)
        {
            throw new NotImplementedException();
        }

        async Task<ActionResult<IEnumerable<Recruiter>>> GetAllEmployer()
        {
            return await _context.recruiters.ToListAsync();
        }
        public Task LoginEmployer(string userName, string password)
        {
            if (userName == null) throw new ArgumentNullException(nameof(userName));
            if(password == null) throw new ArgumentNullException(nameof(password));
            if(userName == _context.recruiters.Where<>)
            {
                return Task.CompletedTask;
            }
            return Task.CompletedTask;
        }

        public async Task<Recruiter> RegisterEmployer(Recruiter recruiter)
        {
            _context.recruiters.Add(recruiter);
            _context.SaveChanges();
            return recruiter;
        }

        public Task UpdateEmployer(int employerId, Recruiter recruiter)
        {
            throw new NotImplementedException();
        }

        async Task<ActionResult<IEnumerable<Recruiter>>> IEmployerRepo.GetAllEmployer()
        {
            return await _context.Recruiter.ToListAsync();
        }
    }
}
