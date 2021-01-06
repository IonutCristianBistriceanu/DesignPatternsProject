using DesignPatters.Proj.Examples.FactoryMethod;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DesignPatters.Proj.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FactoryMethodController : ControllerBase
    {
        private readonly ILogger<FactoryMethodController> _logger;

        public FactoryMethodController(ILogger<FactoryMethodController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("deliver/land")]
        public string DeliverByLand()
        {
            var logistics = new RoadLogistics();
            _logger.Log(LogLevel.Information, "Road logistics initiated.");
            return logistics.DeliverTransport();
        }

        [HttpGet]
        [Route("deliver/sea")]
        public string DeliverBySea()
        {
            var logistics = new SeaLogistics();
            _logger.Log(LogLevel.Information, "Sea logistics initiated.");
            return logistics.DeliverTransport();
        }
    }
}