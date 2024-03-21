using Microsoft.AspNetCore.Mvc;

namespace Parcial_DevOps_HolaMundo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaludoController : ControllerBase
    {
       

        private readonly ILogger<SaludoController> _logger;

        public SaludoController(ILogger<SaludoController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public HolaMundo Get()
        {
            return new HolaMundo();
        }
    }
}