using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals.Utilities
{
    public class PolygonBase
    {
        public List<PointF> GenerateVertices(int sides, PointF center, float radius)
        {
            List<PointF> vertices = new List<PointF>();

            for(int i = 0; i < sides; i++)
            {
                double angle = 2 * Math.PI * i / sides;

                float x = center.X + radius * (float)Math.Cos(angle);
                float y = center.Y + radius * (float)Math.Sin(angle);

                vertices.Add(new PointF(x, y));
            }

            return vertices;
        } 
    }
}
