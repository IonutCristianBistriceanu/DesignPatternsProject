using DesignPatters.Proj.Examples.AbstractFactory.Contracts;
using DesignPatters.Proj.Examples.AbstractFactory.Models.ArtDeco;
using DesignPatters.Proj.Utils;

namespace DesignPatters.Proj.Examples.AbstractFactory.Factories
{
    public class ArtDecoFactory : IAbstractFactory
    {
        // ReSharper disable once HeapView.BoxingAllocation
        private readonly string _productFamily = ProductFamily.ArtDeco.ToString();
        public IChair CreateChair()
        {
            return new ArtDecoChair(_productFamily, ProductUtils.GetProductName(Product.Chair), 100);
        }

        public ISofa CreateSofa()
        {
            return new ArtDecoSofa(_productFamily, ProductUtils.GetProductName(Product.Sofa), 100);
        }

        public ITable CreateTable()
        {
            return new ArtDecoTable(_productFamily,ProductUtils.GetProductName(Product.Table), 100);
        }
    }
}