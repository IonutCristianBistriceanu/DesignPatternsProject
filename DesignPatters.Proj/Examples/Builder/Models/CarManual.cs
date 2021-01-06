namespace DesignPatters.Proj.Examples.Builder.Models
{
    public class CarManual
    {
        public string TripComputer { get; set; }
        public string Gps { get; set; }
        public string Seats { get; set; }
        public string Engine { get; set; }

        public override string ToString()
        {
            return "Car manual";
        }
    }
}