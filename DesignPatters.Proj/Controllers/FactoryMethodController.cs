using DesignPatters.Proj.Examples.FactoryMethod;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DesignPatters.Proj.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FactoryMethodController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public FactoryMethodController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("deliver/land")]
        public string DeliverByLand()
        {
            var logistics = new RoadLogistics();
            return logistics.DeliverTransport();
        }

        [HttpGet]
        [Route("deliver/sea")]
        public string DeliverBySea()
        {
            var logistics = new SeaLogistics();
            return logistics.DeliverTransport();
        }
    }
}