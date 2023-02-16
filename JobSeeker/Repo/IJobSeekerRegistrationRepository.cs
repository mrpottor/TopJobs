using JobSeeker.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobSeeker.Repo
{
    public interface IJobSeekerRegistrationRepository
    {
        Task<JobSeekerRegistration> AddJobSeeker(JobSeekerRegistration Object);
        //public JobSeekerRegistration GetJobSeeker(JobSeekerRegistration Obj);
        //Task LoginJobSeeker(string username, string password);
    }
}
