using Infrastructure.Constants;

namespace PatSite.Server.Models
{
    public class PhysicalConstantsModel
    {
        public static double TimeStep { get => PhysicalConstants.TimeStep; set => PhysicalConstants.TimeStep = value; }
        public static double MinimumSpeed { get => PhysicalConstants.MinimumSpeed; set => PhysicalConstants.MinimumSpeed = value; }
        public static double MaximumSpeed { get => PhysicalConstants.MaximumSpeed; set => PhysicalConstants.MaximumSpeed = value; }
        public static double AirResistance { get => PhysicalConstants.AirResistance; set => PhysicalConstants.AirResistance = value; }
        public static double GravitationalStrength { get => PhysicalConstants.GravitationalStrength; set => PhysicalConstants.GravitationalStrength = value; }
    }
}
