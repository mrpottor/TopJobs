using Employer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employer.Repo
{
    public interface IEmployerRepo
    {
        //List<Recruiter> GetAllEmployer();
        Task<List<Recruiter>> GetAllEmployerAsync();
        Task<Recruiter> RegisterEmployer(Recruiter recruiter);
        Task UpdateEmployer(int employerId, Recruiter recruiter);
        Task DeleteEmployer(int employerId);
        Task LoginEmployer(string userName, string password);

    }
}
