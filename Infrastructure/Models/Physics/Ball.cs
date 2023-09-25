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
            => (X, Y, Force, Radius, Color) = (x, y, force, radius, color);

        public void Move60Fps(double width, double height)
        {
            Force.Add(BallMovementConstants.Gravity);

            X += Force.X;
            Y += Force.Y;

            if (X < 0.0 || X > width)
            {
                Force.X = -Force.X;
                X = Math.Max(0.0, Math.Min(X, width));
            }
            if (Y < 0.0 || Y > height)
            {
                Force.Y = -Force.Y;
                Y = Math.Max(0.0, Math.Min(Y, height));
            }
        }
    }
}