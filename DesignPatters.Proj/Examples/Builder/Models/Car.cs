using DesignPatters.Proj.Examples.Builder.Contracts;

namespace DesignPatters.Proj.Examples.Builder.Models
{
    public class Car
    {
        public bool TripComputer = false;
        public bool Gps = false;
        public int Seats { get; set; }
        public IEngine Engine { get; set; }

        public override string ToString()
        {
            return
                $"Car has a {Engine.Name} and {Seats.ToString()} seats. Trip computer: {TripComputer.ToString()}. GPS: {Gps.ToString()}";
        }
    }
}