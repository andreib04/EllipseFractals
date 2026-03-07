using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals.Utilities
{
    public class EllipseConstraint
    {
        private float a;
        private float b;
        private PointF center;

        public EllipseConstraint(float a, float b, PointF center)
        {
            this.a = a;
            this.b = b;
            this.center = center;
        }

        public bool IsInside(PointF point)      //(x² / a²) + (y² / b²) ≤ 1 (ecuatia elipsei)
        {
            float dx = point.X - center.X;
            float dy = point.Y - center.Y;
            return (dx * dx) / (a * a) + (dy * dy) / (b * b) <= 1;
        }
    }
}
