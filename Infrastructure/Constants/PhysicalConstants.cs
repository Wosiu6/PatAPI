using PatAPI.Infrastructure.Physics;

namespace PatAPI.Infrastructure.Constants
{
    public static class PhysicalConstants
    {
        public static double MinimumSpeed = 5;
        public static double MaximumSpeed = 10;
        public static double TimeStep = 10.0;
        public static double WallElasticity = 0.95;
        public static double AirResistance = 0;
        public static double GravitationalStrength = 3;

        //Forces
        public static ForceVector Gravity = new(0.0, 10.0);
        //public static ForceVector Friction = new(-1.0, 0.0);
    }
}
