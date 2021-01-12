using System.Threading.Tasks;
using DesignPatters.Proj.Examples.AbstractFactory.Contracts;
using DesignPatters.Proj.Examples.CommandPattern;
using DesignPatters.Proj.Examples.CommandPattern.Commands;
using DesignPatters.Proj.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DesignPatters.Proj.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommandController
    {
        private readonly ILogger<BuilderController> _logger;
        private readonly IProductService _productService;

        public CommandController(ILogger<BuilderController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }


        //TODO: Read article and re-design the system with new solution
        [HttpGet]
        [Route("discount")]
        public async Task<IProduct> Get(ProductFamily productFamily, Product product)
        {
            var item = await _productService.GetProduct(productFamily, product);
            var invoker = new Invoker();
            var commandA = new SimpleCommand("Calculating product discount...");
            var commandB = new CalculateDiscountCommand(item);
            invoker.SetOnStart(commandA);
            invoker.SetOnFinish(commandB);
            invoker.Invoke();

            return item;
        }
    }
}