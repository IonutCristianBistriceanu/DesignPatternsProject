using DesignPatters.Proj.Examples.Builder.Contracts;

namespace DesignPatters.Proj.Examples.Builder.Parts.Engine
{
    public class DieselEngine : IEngine
    {
        public string Name { get; set; } = "Diesel engine";
    }
}