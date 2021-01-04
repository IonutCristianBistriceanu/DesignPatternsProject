using DesignPatters.Proj.Examples.AbstractFactory.Contracts;

namespace DesignPatters.Proj.Examples.AbstractFactory.Models.ArtDeco
{
    public class ArtDecoTable : ITable
    {
        public ArtDecoTable(string productFamily, string product)
        {
            ProductFamily = productFamily;
            Product = product;
        }

        public string ProductFamily { get; }
        public string Product { get; }
    }
}