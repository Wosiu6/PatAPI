using PatAPI.Infrastructure.Constants;

namespace PatAPI.Infrastructure.Physics
{
    public class Ballfield
    {
        public readonly List<Ball> Balls = new();
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Ballfield()
        {
        }

        public void Resize(double width, double height) =>
            (Width, Height) = (width, height);

        private static double GenerateRandomVelocity(Random rand, double min, double max) => rand.NextDouble() * (max - min) + min;

        public void AddRandmBall()
        {
            Random rand = new();

            double xVel = GenerateRandomVelocity(rand, PhysicalConstants.MinimumSpeed, PhysicalConstants.MaximumSpeed);
            double yVel = GenerateRandomVelocity(rand, PhysicalConstants.MinimumSpeed, PhysicalConstants.MaximumSpeed);

            long radius = rand.NextInt64(BallConstants.MinRadius, BallConstants.MaxRadius);
            //long radius = 30; // Can't account for various radiuses for now due to a need of much more complex calculations

            Balls.Add(new Ball(
                new Velocity(xVel, yVel),
                rand.NextDouble() * Width,
                rand.NextDouble() * Height,
                radius: radius,
                color: $"#{new Random().Next(0x1000000):X6}"
            ));
        }
    }
}