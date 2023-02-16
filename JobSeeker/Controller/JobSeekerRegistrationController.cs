using JobSeeker.Models;
using JobSeeker.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSeeker.Controller
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
