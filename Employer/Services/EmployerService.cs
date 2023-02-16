using Employer.Models;
using Employer.Repo;

namespace Employer.Services
{
    public class EmployerService : IEmployerService
    {
        private readonly IEmployerRepo _repo;
        public EmployerService(IEmployerRepo repo)
        {
            _repo = repo;
        }
        public bool DeleteEmployer(int employerId)
        {
            throw new NotImplementedException();
        }

        public List<Recruiter> GetEmployers()
        {
            return Task.FromResult<List<Recruiter>>();
        }

        public bool LoginEmployer(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public Recruiter RegisterEmployer(Recruiter recruiter)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEmployer(int employerId, Recruiter recruiter)
        {
            throw new NotImplementedException();
        }
    }
}
