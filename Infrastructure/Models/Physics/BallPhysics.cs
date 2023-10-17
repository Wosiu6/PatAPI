using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Physics
{
    public static class BallPhysics
    {
        public static void CheckDistance(Ballfield ballfield)
        {
            int numberOfBalls = ballfield.Balls.Count;

            for (var i = 0; i < numberOfBalls - 1; i++) // double check if -1 needed
            {
                for (var j = i + 1; j < numberOfBalls; j++)
                {
                    Ball currentTopBall = ballfield.Balls[i];
                    Ball currentBottomBall = ballfield.Balls[j];

                    if (Math.Sqrt((currentTopBall.X - currentBottomBall.X) * (currentTopBall.X - currentBottomBall.X) + (currentTopBall.Y - currentBottomBall.Y) * (currentTopBall.Y - currentBottomBall.Y)) < (currentTopBall.Radius + currentBottomBall.Radius)
                        || (currentBottomBall.Mode == 2 && j == i + 1))
                    {
                        CalculateVelocity(currentTopBall, currentBottomBall);
                    }
                }
            }
        }


        public static void CalculateVelocity(Ball currentTopBall, Ball currentBottomBall)
        {
            var deltaX = currentTopBall.X - currentBottomBall.X;
            var deltaY = currentTopBall.Y - currentBottomBall.Y;
            var deltaR = deltaX * deltaX + deltaY * deltaY;

            double V1x, V1y, V2x, V2y;

            if (deltaR != 0)
            {
                V1x = ((currentBottomBall.Velocity.X * deltaX + currentBottomBall.Velocity.Y * deltaY) * deltaX + (currentTopBall.Velocity.X * deltaY - currentTopBall.Velocity.Y * deltaX) * deltaY) / deltaR;
                V1y = ((currentBottomBall.Velocity.X * deltaX + currentBottomBall.Velocity.Y * deltaY) * deltaY - (currentTopBall.Velocity.X * deltaY - currentTopBall.Velocity.Y * deltaX) * deltaX) / deltaR;
                V2x = ((currentTopBall.Velocity.X * deltaX + currentTopBall.Velocity.Y * deltaY) * deltaX + (currentBottomBall.Velocity.X * deltaY - currentBottomBall.Velocity.Y * deltaX) * deltaY) / deltaR;
                V2y = ((currentTopBall.Velocity.X * deltaX + currentTopBall.Velocity.Y * deltaY) * deltaY - (currentBottomBall.Velocity.X * deltaY - currentBottomBall.Velocity.Y * deltaX) * deltaX) / deltaR;

                currentTopBall.Velocity.X = V1x;
                currentTopBall.Velocity.Y = V1y;
                currentBottomBall.Velocity.X = V2x;
                currentBottomBall.Velocity.Y = V2y;

                var sqrtDr = Math.Sqrt(deltaR);

                if (currentTopBall.Mode != 1)
                {
                    currentTopBall.X += (2 * currentTopBall.Radius - sqrtDr) * (deltaX / sqrtDr) * 0.5;
                    currentTopBall.Y += (2 * currentTopBall.Radius - sqrtDr) * (deltaY / sqrtDr) * 0.5;
                }
                if (currentBottomBall.Mode != 1)
                {
                    currentBottomBall.X -= (2 * currentBottomBall.Radius - sqrtDr) * (deltaX / sqrtDr) * 0.5;
                    currentBottomBall.Y -= (2 * currentBottomBall.Radius - sqrtDr) * (deltaY / sqrtDr) * 0.5;
                }
            }
        }
    }
}
