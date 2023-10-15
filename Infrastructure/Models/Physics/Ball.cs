using Infrastructure.Constants;
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

        public bool IsRolling { get; private set; }

        public Ball(ForceVector force, double radius, string color)
        {
            Radius = radius;
            X = 2 * Radius;
            Y = 2 * Radius;
            Force = force;
            Color = color;

            IsRolling = false;
        }

        public void Move(double width, double height)
        {
            MoveHorizontally();

            if (!IsRolling)
            {
                Force.Add(PhysicalConstants.Gravity);
                MoveVertically();
            }

            void MoveHorizontally()
            {
                X += Force.X * PhysicalConstants.TimeStep;

                if (X <= 0.0 + Radius || X >= width - Radius)
                {
                    Force.X = Force.X * PhysicalConstants.WallElasticity;
                    Force.X = -Force.X;
                    X = Math.Max(0.0, Math.Min(X, width - Radius));
                }
            }

            void MoveVertically()
            {
                Y += Force.Y * PhysicalConstants.TimeStep;

                if (Y <= 0.0 + Radius || Y >= height - Radius)
                {
                    Force.Y = Force.Y * PhysicalConstants.WallElasticity;
                    Force.Y = -Force.Y;
                    Y = Math.Max(0.0, Math.Min(Y, height - Radius));
                }
            }
        }
    }

    public static class BallConstants
    {
        public static int MaxRadius = 15;
        public static int MinRadius = 5;
    }
}