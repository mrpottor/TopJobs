using Employer.Models;

namespace Employer.Repo
{
    public interface IJobSeekerRegistrationRepository
    {
        public int AddJobSeeker(JobSeekerRegistration Object);
        //Task LoginJobSeeker(string username, string password);
    }
}
