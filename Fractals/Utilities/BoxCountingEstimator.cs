using System;
using System.Collections.Generic;
using System.Drawing;

namespace Fractals.Utilities
{
    public class BoxCountingEstimator
    {
        public List<BoxCell> Cells { get; private set; } = new List<BoxCell>();

        public double EstimatedDimension { get; private set; }

        public void Compute(List<Branch> branches, Size canvasSize)
        {
            Cells.Clear();

            List<double> eps = new List<double>();
            List<double> counts = new List<double>();

            float[] boxSizes = { 128, 64, 32, 16 };

            foreach (float boxSize in boxSizes)
            {
                int count = 0;

                int cols = (int)Math.Ceiling(canvasSize.Width / boxSize);
                int rows = (int)Math.Ceiling(canvasSize.Height / boxSize);

                for (int x = 0; x < cols; x++)
                {
                    for (int y = 0; y < rows; y++)
                    {
                        RectangleF rect = new RectangleF(
                            x * boxSize,
                            y * boxSize,
                            boxSize,
                            boxSize);

                        bool contains = BoxContainsBranch(rect, branches);

                        if (contains)
                        {
                            count++;

                            if (boxSize == 32) // level used for drawing
                            {
                                Cells.Add(new BoxCell(rect) { ContainsFractal = true });
                            }
                        }
                    }
                }

                eps.Add(boxSize);
                counts.Add(count);
            }

            EstimatedDimension = ComputeSlope(eps, counts);
        }

        private bool BoxContainsBranch(RectangleF rect, List<Branch> branches)
        {
            foreach (var b in branches)
            {
                if (rect.Contains(b.Start) || rect.Contains(b.End))
                    return true;

                if (LineIntersectsRect(b.Start, b.End, rect))
                    return true;
            }

            return false;
        }

        private double ComputeSlope(List<double> eps, List<double> counts)
        {
            int n = eps.Count;

            double sumX = 0;
            double sumY = 0;
            double sumXY = 0;
            double sumXX = 0;

            for (int i = 0; i < n; i++)
            {
                double x = Math.Log(1 / eps[i]);
                double y = Math.Log(counts[i]);

                sumX += x;
                sumY += y;
                sumXY += x * y;
                sumXX += x * x;
            }

            double slope = (n * sumXY - sumX * sumY) /
                           (n * sumXX - sumX * sumX);

            return slope;
        }

        private bool LineIntersectsRect(PointF p1, PointF p2, RectangleF r)
        {
            return LineIntersectsLine(p1, p2, new PointF(r.Left, r.Top), new PointF(r.Right, r.Top)) ||
                   LineIntersectsLine(p1, p2, new PointF(r.Right, r.Top), new PointF(r.Right, r.Bottom)) ||
                   LineIntersectsLine(p1, p2, new PointF(r.Right, r.Bottom), new PointF(r.Left, r.Bottom)) ||
                   LineIntersectsLine(p1, p2, new PointF(r.Left, r.Bottom), new PointF(r.Left, r.Top));
        }

        private bool LineIntersectsLine(PointF a1, PointF a2, PointF b1, PointF b2)
        {
            float d = (a2.X - a1.X) * (b2.Y - b1.Y) - (a2.Y - a1.Y) * (b2.X - b1.X);

            if (d == 0)
                return false;

            float u = ((b1.X - a1.X) * (b2.Y - b1.Y) - (b1.Y - a1.Y) * (b2.X - b1.X)) / d;
            float v = ((b1.X - a1.X) * (a2.Y - a1.Y) - (b1.Y - a1.Y) * (a2.X - a1.X)) / d;

            return (u >= 0 && u <= 1 && v >= 0 && v <= 1);
        }
    }
}
