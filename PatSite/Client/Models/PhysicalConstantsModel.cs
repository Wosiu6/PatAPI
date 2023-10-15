using Infrastructure.Constants;

namespace PatSite.Server.Models
{
    public class PhysicalConstantsModel
    {
        public double TimeStep { get => PhysicalConstants.TimeStep; set => PhysicalConstants.TimeStep = value; }
        public double MinimumSpeed { get => PhysicalConstants.MinimumSpeed; set => PhysicalConstants.MinimumSpeed = value; }
        public double MaximumSpeed { get => PhysicalConstants.MaximumSpeed; set => PhysicalConstants.MaximumSpeed = value; }
        public double AirResistance { get => PhysicalConstants.AirResistance; set => PhysicalConstants.AirResistance = value; }
        public double GravitationalStrength { get => PhysicalConstants.GravitationalStrength; set => PhysicalConstants.GravitationalStrength = value; }
    }
}
