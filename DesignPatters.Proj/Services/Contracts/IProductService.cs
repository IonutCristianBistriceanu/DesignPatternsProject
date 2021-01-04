using System.Threading.Tasks;
using DesignPatters.Proj.Examples.AbstractFactory.Contracts;

namespace DesignPatters.Proj.Services.Contracts
{
    public interface IProductService
    {
        Task<IProduct> GetProduct(ProductFamily productFamily, Product product);
    }
}