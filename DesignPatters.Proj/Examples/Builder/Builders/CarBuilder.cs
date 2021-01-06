using DesignPatters.Proj.Examples.Builder.Contracts;
using DesignPatters.Proj.Examples.Builder.Models;

namespace DesignPatters.Proj.Examples.Builder.Builders
{
    public class CarBuilder : IBuilder
    {
        private Car _car;

        public CarBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _car = new Car();
        }

        public void SetSeats(int numberOfSeats)
        {
            _car.Seats = numberOfSeats;
        }

        public void SetEngine(IEngine engine)
        {
            _car.Engine = engine;
        }

        public void SetTripComputer()
        {
            _car.TripComputer = true;
        }

        public void SetGps()
        {
            _car.Gps = true;
        }

        public Car GetProduct()
        {
            var product = _car;
            Reset();
            return product;
        }
    }
}