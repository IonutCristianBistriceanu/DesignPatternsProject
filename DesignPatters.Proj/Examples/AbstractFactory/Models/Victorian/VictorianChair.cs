using DesignPatters.Proj.Examples.AbstractFactory.Contracts;

namespace DesignPatters.Proj.Examples.AbstractFactory.Models.Victorian
{
    public class VictorianChair : IChair
    {
        public VictorianChair(string productFamily, string product)
        {
            ProductFamily = productFamily;
            Product = product;
        }

        public string ProductFamily { get; }
        public string Product { get; }
    }
}