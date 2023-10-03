using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Physics
{
    public static class BallMovementConstants
    {
        public static double MinimumSpeed = 5;
        public static double MaximumSpeed = 10;
        public static ForceVector Gravity = new(0.0, 10.0);
        public static double TimeStep = 1.0 / 10.0;
    }
}
