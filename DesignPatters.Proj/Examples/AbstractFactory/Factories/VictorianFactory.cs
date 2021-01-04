using DesignPatters.Proj.Examples.AbstractFactory.Contracts;
using DesignPatters.Proj.Examples.AbstractFactory.Models.Victorian;
using DesignPatters.Proj.Utils;

namespace DesignPatters.Proj.Examples.AbstractFactory.Factories
{
    public class VictorianFactory : IAbstractFactory
    {
        // ReSharper disable once HeapView.BoxingAllocation
        private readonly string _productFamily = ProductFamily.Victorian.ToString();

        public IChair CreateChair()
        {
            return new VictorianChair(_productFamily, ProductUtils.GetProductName(Product.Chair));
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa(_productFamily, ProductUtils.GetProductName(Product.Sofa));
        }

        public ITable CreateTable()
        {
            return new VictorianTable(_productFamily, ProductUtils.GetProductName(Product.Table));
        }
    }
}