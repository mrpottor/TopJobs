using JobApplication.Services;
using Microsoft.AspNetCore.Mvc;
using JobApplication.Models;



namespace JobApplication.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class JSApplicationsController : ControllerBase
    {
        public readonly IJobApplicationService service;
        public JSApplicationsController(IJobApplicationService _service)
        {
            service = _service;
        }
        [HttpGet]
        public List<Class> Get()
        {
            return service.GetProducts();
        }

        [HttpPost]
        public ActionResult Post(Class c)
        {
            var result = service.AddProduct(c);
            if (result == 1)
            {
                return StatusCode(201, $"{result} Record Added");
            }
            return StatusCode(500);
        }
    }
}
