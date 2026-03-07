using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals.Utilities
{
    public class FractalRenderer
    {
        public void Draw(Graphics g, List<Branch> branches, int mode)
        {
            Random rand = new Random();

            foreach (var b in branches)
            {
                float width = Math.Max(1f, 6f - b.Depth);

                int shade = Math.Max(0, 200 - b.Depth * 20);

                Color color = Color.FromArgb(shade, shade / 2, 0);

                using (Pen pen = new Pen(color, width))
                {
                    if (mode == 0)
                    {
                        g.DrawLine(pen, b.Start, b.End);
                    }
                    else if (mode == 1)
                    {
                        DrawBezierBranch(g, pen, b);
                    }
                    else if (mode == 2)
                    {
                        DrawOrganicBranch(g, pen, b, rand);
                    }
                }
            }
        }

        private void DrawBezierBranch(Graphics g, Pen pen, Branch b)
        {
            float midX = (b.Start.X + b.End.X) / 2;
            float midY = (b.Start.Y + b.End.Y) / 2;

            float curveOffset = 20f;

            PointF control = new PointF(
                midX + curveOffset,
                midY - curveOffset
            );

            g.DrawBezier(
                pen,
                b.Start,
                control,
                control,
                b.End
            );
        }

        private void DrawOrganicBranch(Graphics g, Pen pen, Branch b, Random rand)
        {
            float midX = (b.Start.X + b.End.X) / 2;
            float midY = (b.Start.Y + b.End.Y) / 2;

            float windX = rand.Next(-30, 30);
            float windY = rand.Next(-30, 30);

            PointF control1 = new PointF(midX + windX, midY + windY);
            PointF control2 = new PointF(midX - windX, midY - windY);

            g.DrawBezier(
                pen,
                b.Start,
                control1,
                control2,
                b.End
            );
        }
    }
}
