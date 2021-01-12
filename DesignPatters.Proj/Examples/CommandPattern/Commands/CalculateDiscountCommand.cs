using DesignPatters.Proj.Examples.AbstractFactory.Contracts;
using DesignPatters.Proj.Examples.Command;
using DesignPatters.Proj.Utils;

namespace DesignPatters.Proj.Examples.CommandPattern.Commands
{
    public class CalculateDiscountCommand : ICommand
    {
        private IProduct _product;
        private IDiscountCalculator _discountCalculator;

        public CalculateDiscountCommand(IProduct product)
        {
            _product = product;
            _discountCalculator = new DiscountCalculator();
        }

        public void Execute()
        {
            _discountCalculator.CalculateDiscount(_product);
        }
    }
}