using System.Threading.Tasks;
using DesignPatters.Proj.Examples.AbstractFactory.Contracts;
using DesignPatters.Proj.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DesignPatters.Proj.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AbstractFactoryController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IProductService _productService;

        public AbstractFactoryController(ILogger<WeatherForecastController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet]
        public async Task<IProduct> Get(ProductFamily productFamily, Product product)
        {
            var item = await _productService.GetProduct(productFamily, product);
            _logger.Log(LogLevel.Information, $"Product returned is {item}");
            return item;
        }
    }
}