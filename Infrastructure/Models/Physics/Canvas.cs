using Infrastructure.Utils;
using System;

namespace Infrastructure.Models.Physics
{
    public class Canvas
    {
        public readonly List<Ball> Balls = new();
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Canvas()
        {
        }

        public void Resize(double width, double height) =>
            (Width, Height) = (width, height);

        private double RandomVelocity(Random rand, double min, double max)
        {
            return rand.NextDouble() * (max - min) + min;
        }

        public void AddRandmBall()
        {
            Random rand = new();

            double xVel = RandomVelocity(rand, BallMovementConstants.MinimumSpeed, BallMovementConstants.MaximumSpeed);
            //double yVel = RandomVelocity(rand, BallMovementConstants.MinimumSpeed, BallMovementConstants.MaximumSpeed);

            long radius = rand.NextInt64(5, 15);

            Balls.Add(new Ball(
                radius,
                Height - radius,
                new ForceVector(xVel, 0),
                radius: radius,
                color: "#FF0000"
            //color: DrawingUtils.GenerateRandomColor().ToString()
            ));
        }
    }
}