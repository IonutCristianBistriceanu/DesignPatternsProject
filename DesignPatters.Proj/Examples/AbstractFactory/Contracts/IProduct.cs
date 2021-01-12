namespace DesignPatters.Proj.Examples.AbstractFactory.Contracts
{
    public interface IProduct
    {
        public string ProductFamily { get; }
        public string Product { get; }
        public double Price { get; set; }
    }
}