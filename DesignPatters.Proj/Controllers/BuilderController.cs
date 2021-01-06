using DesignPatters.Proj.Examples.Builder.Builders;
using DesignPatters.Proj.Examples.Builder.Directors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DesignPatters.Proj.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuilderController : ControllerBase
    {
        private readonly ILogger<BuilderController> _logger;
        private readonly Director _director;

        public BuilderController(ILogger<BuilderController> logger)
        {
            _logger = logger;
            _director = new Director();
        }

        [HttpGet]
        [Route("build/sportsCar")]
        public string ConstructSportsCar()
        {
            var carBuilder = new CarBuilder();
            _director.ConstructSportsCar(carBuilder);
            var car = carBuilder.GetProduct();
            return car.ToString();
        }

        [HttpGet]
        [Route("build/suv")]
        public string ConstructSuv()
        {
            var carBuilder = new CarBuilder();
            _director.ConstructSuv(carBuilder);
            var car = carBuilder.GetProduct();
            return car.ToString();
        }
        
        [HttpGet]
        [Route("build/sportsCarManual")]
        public string WriteSportsCarManual()
        {
            var carManualBuilder = new CarManualBuilder();
            _director.ConstructSportsCar(carManualBuilder);
            var manual = carManualBuilder.GetProduct();
            return manual.ToString();
        }

        [HttpGet]
        [Route("build/suvManual")]
        public string WriteSuvManual()
        {
            var carManualBuilder = new CarManualBuilder();
            _director.ConstructSuv(carManualBuilder);
            var manual = carManualBuilder.GetProduct();
            return manual.ToString();
        }
    }
}