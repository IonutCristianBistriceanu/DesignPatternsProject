using System;
using System.Threading.Tasks;
using DesignPatters.Proj.Examples.AbstractFactory;
using DesignPatters.Proj.Examples.AbstractFactory.Contracts;
using DesignPatters.Proj.Examples.AbstractFactory.Factories;

namespace DesignPatters.Proj.Services.Contracts
{
    public class ProductService : IProductService
    {
        public async Task<IProduct> GetProduct(ProductFamily productFamily, Product product)
        {
            IAbstractFactory factory = CreateFactory(productFamily);
            var finalProduct = CreateProduct(factory, product);
            await Task.Delay(100);
            return finalProduct;
        }

        private IProduct CreateProduct(IAbstractFactory factory, Product product)
        {
            return product switch
            {
                Product.Chair => factory.CreateChair(),
                Product.Sofa => factory.CreateSofa(),
                Product.Table => factory.CreateTable(),
                _ => throw new ArgumentOutOfRangeException(nameof(product), product, null)
            };
        }

        private IAbstractFactory CreateFactory(ProductFamily productFamily)
        {
            return productFamily switch
            {
                ProductFamily.ArtDeco => new ArtDecoFactory(),
                ProductFamily.Modern => new ModernFactory(),
                ProductFamily.Victorian => new VictorianFactory(),
                _ => throw new ArgumentOutOfRangeException(nameof(productFamily), productFamily, null)
            };
        }
    }
}