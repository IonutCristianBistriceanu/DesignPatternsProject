using DesignPatters.Proj.Examples.AbstractFactory.Contracts;

namespace DesignPatters.Proj.Utils
{
    public static class ProductUtils
    {
        public static string GetProductName(Product product)
        {
            // ReSharper disable once HeapView.BoxingAllocation
            return product.ToString();
        }
    }
}