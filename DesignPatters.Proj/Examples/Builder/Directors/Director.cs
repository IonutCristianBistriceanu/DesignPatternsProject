using DesignPatters.Proj.Examples.Builder.Contracts;
using DesignPatters.Proj.Examples.Builder.Parts.Engine;

namespace DesignPatters.Proj.Examples.Builder.Directors
{
    public class Director
    {
        private IBuilder _builder;

        public void SetBuilder(IBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructSportsCar(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(2);
            builder.SetEngine(new SportEngine());
            builder.SetTripComputer();
            builder.SetGps();
        }

        public void ConstructSuv(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(4);
            builder.SetEngine(new DieselEngine());
            builder.SetTripComputer();
            builder.SetGps();
        }
    }
}