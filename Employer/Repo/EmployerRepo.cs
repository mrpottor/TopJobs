using Microsoft.EntityFrameworkCore;
using Employer.Models;
using Microsoft.AspNetCore.Mvc;
using Employer.Data;
using System.ComponentModel;
using System.Collections.Specialized;

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

        async Task<List<Recruiter>> GetAllEmployerAsync()
        {
            return await _context.recruiters.ToListAsync();
        }
        public Task LoginEmployer(string userName, string password)
        {
            if (userName == null) throw new ArgumentNullException(nameof(userName));
            if(password == null) throw new ArgumentNullException(nameof(password));
             
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

        Task<List<Recruiter>> IEmployerRepo.GetAllEmployerAsync()
        {
            throw new NotImplementedException();
        }
    }
}
