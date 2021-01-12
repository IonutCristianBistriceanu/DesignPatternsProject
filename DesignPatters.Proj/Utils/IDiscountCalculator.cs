using DesignPatters.Proj.Examples.AbstractFactory.Contracts;

namespace DesignPatters.Proj.Utils
{
    public interface IDiscountCalculator
    {
        void CalculateDiscount(IProduct product);
    }
}