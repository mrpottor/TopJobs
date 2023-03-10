using Employer.Models;

namespace Employer.Services
{
    public interface IEmployerService
    {
        Recruiter RegisterEmployer(Recruiter recruiter);

        List<Recruiter> GetEmployers();
        bool UpdateEmployer(int employerId, Recruiter recruiter);
        bool DeleteEmployer(int employerId);
        bool LoginEmployer(string userName, string password);
    }
}
