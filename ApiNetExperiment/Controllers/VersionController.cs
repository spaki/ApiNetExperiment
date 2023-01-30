using Microsoft.AspNetCore.Mvc;

namespace ApiNetExperiment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VersionController : ControllerBase
    {
        [HttpGet]
        public string Get() => "1.0";
    }
}