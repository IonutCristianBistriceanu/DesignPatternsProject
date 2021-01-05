using DesignPatters.Proj.Examples.FactoryMethod.MachineModels;

namespace DesignPatters.Proj.Examples.FactoryMethod
{
    public class RoadLogistics : Logistics
    {
        protected override ITransport CreateTransport()
        {
           return new Truck();
        }
    }
}