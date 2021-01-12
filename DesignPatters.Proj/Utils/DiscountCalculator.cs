using DesignPatters.Proj.Examples.AbstractFactory.Contracts;

namespace DesignPatters.Proj.Utils
{
    public class DiscountCalculator : IDiscountCalculator
    {
        public void CalculateDiscount(IProduct product)
        {
            product.Price *= 0.95d;
        }
    }
}