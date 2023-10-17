using Infrastructure.Constants;
using Infrastructure.Models.Extensions;
using System.Diagnostics;

namespace Infrastructure.Models.Physics
{
    public class Ball
    {
        public Velocity Velocity { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Radius { get; private set; }
        public string Color { get; private set; }
        public int Mode { get; private set; }

        public bool IsRolling { get; private set; }

        public Ball() { }
        public Ball(Velocity velocity, double x, double y, double radius, string color, int mode = 0)
        {
            Radius = radius;
            X = x;
            Y = y;
            Velocity = velocity;
            Color = color;
            Mode = 0;
            IsRolling = false;
        }

        public void Move(double width, double height)
        {
            MoveHorizontally();

            MoveVertically();

            void MoveHorizontally()
            {
                
            }

            void MoveVertically()
            {
                
            }
        }
    }

    public static class BallConstants
    {
        public static int MaxRadius = 40;
        public static int MinRadius = 20;
    }
}