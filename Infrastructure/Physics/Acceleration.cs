namespace PatAPI.Infrastructure.Physics
{
    public class Acceleration
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Acceleration(double x, double y) => (X, Y) = (x, y);
    }
}
