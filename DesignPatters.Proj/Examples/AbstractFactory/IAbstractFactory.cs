using DesignPatters.Proj.Examples.AbstractFactory.Contracts;

namespace DesignPatters.Proj.Examples.AbstractFactory
{
    public interface IAbstractFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
        ITable CreateTable();
    }
}