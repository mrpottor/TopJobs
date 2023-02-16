using Employer.Models;
using Employer.Services;
using Microsoft.AspNetCore.Mvc;

namespace Employer.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobSeekerRegistrationController : ControllerBase
    {
        private readonly IJobSeekerRegistrationService Object;
        public JobSeekerRegistrationController(IJobSeekerRegistrationService db)
        {
            Object = db;
        }

        [HttpPost]
        public bool Post(JobSeekerRegistration c)
        {
           return Object.AddJobSeeker(c);
        }
    }
}
