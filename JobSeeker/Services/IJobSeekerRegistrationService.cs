using Employer.Models;

namespace Employer.Services
{
    public interface IJobSeekerRegistrationService
    {
        public bool AddJobSeeker(JobSeekerRegistration Object);
    }
}
