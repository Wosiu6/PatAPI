using Infrastructure.Constants;
using Infrastructure.Models.Physics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Extensions
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
