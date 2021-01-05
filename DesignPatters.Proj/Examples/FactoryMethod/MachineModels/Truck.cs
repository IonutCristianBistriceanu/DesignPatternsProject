namespace DesignPatters.Proj.Examples.FactoryMethod.MachineModels
{
    public class Truck : ITransport
    {
        public string Deliver()
        {
            return "Deliver by land!";
        }
    }
}