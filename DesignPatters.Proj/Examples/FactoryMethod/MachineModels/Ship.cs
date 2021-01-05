namespace DesignPatters.Proj.Examples.FactoryMethod.MachineModels
{
    public class Ship : ITransport
    {
        public string Deliver()
        {
            return "Deliver by Sea!";
        }
    }
}