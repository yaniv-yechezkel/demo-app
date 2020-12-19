using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class DemoController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public DemoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok($"Hello from {_configuration["REGION"]}");
        }
    }
}
