using DesignPatters.Proj.Examples.Builder.Contracts;
using DesignPatters.Proj.Examples.Builder.Models;

namespace DesignPatters.Proj.Examples.Builder.Builders
{
    public class CarManualBuilder : IBuilder
    {
        private CarManual _manual;
        
        public void Reset()
        {
            _manual = new CarManual();
        }

        public void SetSeats(int numberOfSeats)
        {
            _manual.Seats = "Documented car seat features!";
        }

        public void SetEngine(IEngine engine)
        {
            _manual.Seats = "Documented car engine features!";
        }

        public void SetTripComputer()
        {
            _manual.Seats = "Documented car trip computer features!";
        }

        public void SetGps()
        {
            _manual.Seats = "Documented car gps features!";
        }
        
        public CarManual GetProduct()
        {
            var product = _manual;
            Reset();
            return product;
        }
    }
}