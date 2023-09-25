using System.Drawing;

namespace Infrastructure.Utils
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
