using DesignPatters.Proj.Examples.AbstractFactory.Contracts;

namespace DesignPatters.Proj.Examples.AbstractFactory.Models.ArtDeco
{
    public class ArtDecoChair : IChair
    {
        public ArtDecoChair(string productFamily, string product)
        {
            ProductFamily = productFamily;
            Product = product;
        }

        public string ProductFamily { get; }
        public string Product { get; }
    }
}