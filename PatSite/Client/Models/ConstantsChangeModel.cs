using Infrastructure.Constants;
using System.Reflection;

namespace PatSite.Server.Models
{
    public class ConstantsChangeModel
    {
        public double TimeStep { get => PhysicalConstants.TimeStep; set => PhysicalConstants.TimeStep = value; }
        public double MinimumSpeed { get => PhysicalConstants.MinimumSpeed; set => PhysicalConstants.MinimumSpeed = value; }
        public double MaximumSpeed { get => PhysicalConstants.MaximumSpeed; set => PhysicalConstants.MaximumSpeed = value; }
    }
}
