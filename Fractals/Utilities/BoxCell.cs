using System.Drawing;

namespace Fractals.Utilities
{
    public class BoxCell
    {
        public RectangleF Rect { get; set; }

        public bool ContainsFractal { get; set; }

        public BoxCell(RectangleF rect)
        {
            Rect = rect;
            ContainsFractal = false;
        }
    }
}
