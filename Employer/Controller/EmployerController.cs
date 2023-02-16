using Employer.Models;
using Employer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employer.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerController : ControllerBase
    {
        private readonly IEmployerService _employerService;
        public EmployerController(IEmployerService employerService) 
        {
            _employerService = employerService;
        }

        [HttpGet]
        List<Recruiter> Get() 
        {
            return _employerService.GetEmployers();
        }
    }
}
