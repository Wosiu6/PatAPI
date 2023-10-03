using Infrastructure.Models.Physics;
using System.Reflection;

namespace PatSite.Server.Models
{
    public class ConstantsChangeModel
    {
        public double TimeStep { get => BallMovementConstants.TimeStep; set => BallMovementConstants.TimeStep = value; }
        public double MinimumSpeed { get => BallMovementConstants.MinimumSpeed; set => BallMovementConstants.MinimumSpeed = value; }
        public double MaximumSpeed { get => BallMovementConstants.MaximumSpeed; set => BallMovementConstants.MaximumSpeed = value; }
    }
}
