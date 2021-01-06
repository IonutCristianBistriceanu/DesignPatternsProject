namespace DesignPatters.Proj.Examples.Builder.Contracts
{
    public interface IBuilder
    {
        void Reset();
        void SetSeats(int numberOfSeats);
        void SetEngine(IEngine engine);
        void SetTripComputer();
        void SetGps();
        
    }
}