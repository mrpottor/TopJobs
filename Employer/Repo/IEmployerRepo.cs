using Employer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employer.Repo
{
    public interface IEmployerRepo
    {
        Task<ActionResult<IEnumerable<Recruiter>>> GetAllEmployer();
        Task<Recruiter> RegisterEmployer(Recruiter recruiter);
        Task UpdateEmployer(int employerId, Recruiter recruiter);
        Task DeleteEmployer(int employerId);
        Task LoginEmployer(string userName, string password);
        //IEnumerable<Recruiter> GetAllEmployer();
    }
}
