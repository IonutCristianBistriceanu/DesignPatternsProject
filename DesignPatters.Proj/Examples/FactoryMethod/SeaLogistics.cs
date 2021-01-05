using DesignPatters.Proj.Examples.FactoryMethod.MachineModels;

namespace DesignPatters.Proj.Examples.FactoryMethod
{
    public class SeaLogistics : Logistics
    {
        protected override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}