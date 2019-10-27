using Composite.Types;

namespace Composite
{
    public abstract class Vehicle
    {
        public int ID { get; set; }
        public double MaxV { get; set; }
        public int NumberOfPassengers { get; set; }
        public double MaxLoad { get; set; }
        public Status Status { get; set; }
    }
}
