using ApiNetExperiment.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ApiNetExperiment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalcController : ControllerBase
    {
        private readonly ILogger<CalcController> _logger;
        private readonly CalcService _service;

        public CalcController(ILogger<CalcController> logger, CalcService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet("Sum")]
        public CalcResult Sum(decimal a, decimal b)
        {
            _logger.LogInformation("Sum called");
            return _service.Sum(a, b);
        }

        [HttpGet("Subtract")]
        public CalcResult Subtract(decimal a, decimal b)
        {
            _logger.LogInformation("Subtract called");
            return _service.Subtract(a, b);
        }
    }
}