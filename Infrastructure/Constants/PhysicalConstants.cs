using Infrastructure.Models.Physics;

namespace Infrastructure.Constants
{
    public static class PhysicalConstants
    {
        public static double MinimumSpeed = 5;
        public static double MaximumSpeed = 10;
        public static double TimeStep = 1.0 / 10.0;
        public static double WallElasticity = 0.99;

        //Forces
        public static ForceVector Gravity = new(0.0, 10.0);
        //public static ForceVector Friction = new(-1.0, 0.0);
    }
}
