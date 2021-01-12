using DesignPatters.Proj.Examples.AbstractFactory.Contracts;
using DesignPatters.Proj.Examples.AbstractFactory.Models.Modern;
using DesignPatters.Proj.Utils;

namespace DesignPatters.Proj.Examples.AbstractFactory.Factories
{
    public class ModernFactory : IAbstractFactory
    {
        // ReSharper disable once HeapView.BoxingAllocation
        private readonly string _productFamily = ProductFamily.Modern.ToString();

        public IChair CreateChair()
        {
            return new ModernChair(_productFamily, ProductUtils.GetProductName(Product.Chair), 100);
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa(_productFamily, ProductUtils.GetProductName(Product.Sofa), 100);
        }

        public ITable CreateTable()
        {
            return new ModernTable(_productFamily, ProductUtils.GetProductName(Product.Table), 100);
        }
    }
}