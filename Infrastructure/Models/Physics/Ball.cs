using Infrastructure.Models.Extensions;
using System.Diagnostics;

namespace Infrastructure.Models.Physics
{
    public class Ball
    {
        public ForceVector Force { get; set; }
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Radius { get; private set; }
        public string Color { get; private set; }

        public bool IsRolling {  get; private set; }

        public Stopwatch BounceStopwatch { get; private set; }

        public Ball(ForceVector force, double radius, string color)
        {
            Radius = radius;
            X = Radius + 50;
            Y = Radius + 50;
            Force = force;
            Color = color;

            IsRolling = false;
            BounceStopwatch = new Stopwatch();
            BounceStopwatch.Start();
        }

        public void Move60Fps(double width, double height)
        {
            Force.Add(BallMovementConstants.Gravity);

            X += Force.X * BallMovementConstants.TimeStep;
            Y += Force.Y * BallMovementConstants.TimeStep;

            if (X <= 0.0 || X >= width)
            {
                Force.X = -Force.X;
                X = Math.Max(0.0, Math.Min(X, width));
            }
            if (Y <= 0.0 || Y >= height)
            {
                Force.Y = -Force.Y;
                Y = Math.Max(0.0, Math.Min(Y, height));
            }

            if (!IsRolling && Force.Y > -Radius/2 && Force.Y < Radius/2 && Y >= height) IsRolling = true;
        }
    }
}