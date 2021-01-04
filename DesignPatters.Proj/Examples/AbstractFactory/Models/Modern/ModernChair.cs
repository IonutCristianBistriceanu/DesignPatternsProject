using DesignPatters.Proj.Examples.AbstractFactory.Contracts;

namespace DesignPatters.Proj.Examples.AbstractFactory.Models.Modern
{
    public class ModernChair : IChair
    {
        public ModernChair(string productFamily, string product)
        {
            ProductFamily = productFamily;
            Product = product;
        }

        public string ProductFamily { get; }
        public string Product { get; }
    }
}