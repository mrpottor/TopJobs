using JobSeeker.Models;

namespace JobSeeker.Services
{
    public interface IJobSeekerRegistrationService
    {
        public bool AddJobSeeker(JobSeekerRegistration Object);
    }
}
