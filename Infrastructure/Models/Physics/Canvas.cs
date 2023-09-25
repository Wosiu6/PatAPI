using Infrastructure.Utils;

namespace Infrastructure.Models.Physics
{
    public class Canvas
    {
        public readonly List<Ball> Balls = new();
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Canvas()
        {
            Random rand = new();

            double xVel = RandomVelocity(rand, BallMovementConstants.MinimumSpeed, BallMovementConstants.MaximumSpeed);
            double yVel = RandomVelocity(rand, BallMovementConstants.MinimumSpeed, BallMovementConstants.MaximumSpeed);

            Balls.Add(new Ball(
                1,
                Height,
                new ForceVector(xVel, yVel),
                radius: rand.NextInt64(5, 15),
                color: DrawingUtils.GenerateRandomColor().ToString()
            ));
        }

        public void Resize(double width, double height) =>
            (Width, Height) = (width, height);

        private double RandomVelocity(Random rand, double min, double max)
        {
            return min + (max - min) * rand.NextDouble();
        }
    }
}