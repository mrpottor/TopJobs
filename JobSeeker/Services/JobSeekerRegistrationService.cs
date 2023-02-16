using JobSeeker.Models;
using JobSeeker.Repo;
using JobSeeker.Services;

namespace JobSeeker.Services
{
    public class JobSeekerRegistrationService : IJobSeekerRegistrationService
    {
        private readonly IJobSeekerRegistrationRepository repo;
        public JobSeekerRegistrationService(IJobSeekerRegistrationRepository _repo)
        {
            repo = _repo;
        }
        public bool AddJobSeeker(JobSeekerRegistration Object)
        {
            var result = repo.AddJobSeeker(Object);
            if (result == 1)
            {
                return true;
            }
            return false;
        }

    }
}
