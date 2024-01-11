using PatAPI.Infrastructure.Constants;
using PatAPI.Infrastructure.Physics;

namespace PatAPI.Infrastructure.Extensions
{
    public static class ForceVectorExtensions
    {
        public static void Add(this ForceVector originalVector, ForceVector newVector)
        {
            originalVector.X += newVector.X * PhysicalConstants.TimeStep;
            originalVector.Y += newVector.Y * PhysicalConstants.TimeStep;
        }
    }
}
