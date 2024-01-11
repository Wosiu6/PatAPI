using System.Drawing;

namespace PatAPI.Infrastructure.Utils
{
    public static class DrawingUtils
    {
        public static Color GenerateRandomColor()
        {
            Random random = new();
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
    }
}
