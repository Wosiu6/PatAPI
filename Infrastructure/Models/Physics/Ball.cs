using Infrastructure.Models.Extensions;

namespace Infrastructure.Models.Physics
{
    public class Ball
    {
        public ForceVector Force { get; set; }
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Radius { get; private set; }
        public string Color { get; private set; }

        public Ball(double x, double y, ForceVector force, double radius, string color)
        {
            Radius = radius;
            X = Radius;
            Y = Radius;
            Force = force;
            Color = color;
        }

        public void Move60Fps(double width, double height)
        {
            Force.Add(BallMovementConstants.Gravity);

            X += Force.X * BallMovementConstants.TimeStep;
            Y += Force.Y * BallMovementConstants.TimeStep;

            if (X < 0.0 + Radius || X > width - Radius)
            {
                Force.X = -Force.X;
                X = Math.Max(0.0, Math.Min(X, width));
            }
            if (Y < 0.0 + Radius || Y > height - Radius*1.1)
            {
                Force.Y = -Force.Y;
                Y = Math.Max(0.0, Math.Min(Y, height));
            }
        }
    }
}