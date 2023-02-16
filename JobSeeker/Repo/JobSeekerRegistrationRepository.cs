using JobSeeker.Models;
using JobSeeker.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobSeeker.Repo
{
    public class JobSeekerRegistrationRepository : IJobSeekerRegistrationRepository
    {
        private readonly DataContext db;
        public JobSeekerRegistrationRepository(DataContext db)
        {
            this.db = db;
        }

        public async Task<JobSeekerRegistration> AddJobSeeker(JobSeekerRegistration Object)
        {
            //db.Add(Object.JobSeekerID);
            //db.Add(Object.JobSeekerFirstName);
            //db.Add(Object.JobSeekerLastName);
            //db.Add(Object.JobSeekerUserName);
            //db.Add(Object.JobSeekerPassword);
            //db.Add(Object.JobSeekerQualification);
            //db.Add(Object.JobSeekerYOP);
            //db.Add(Object.JobSeekerTotalExp);
                db.Add(Object);
                db.SaveChanges();
            return Object;
        }
    }
}
