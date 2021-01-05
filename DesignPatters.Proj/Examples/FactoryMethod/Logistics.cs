namespace DesignPatters.Proj.Examples.FactoryMethod
{
    public abstract class Logistics
    {
        protected abstract ITransport CreateTransport();

        public string DeliverTransport()
        {
            var transport = CreateTransport();
            return transport.Deliver();
        }
    }
}