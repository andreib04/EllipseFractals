using Fractals.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Fractals.Utilities
{
    public class BranchGenerator
    {
        private FractalParameters parameters;
        private RandomProvider random;
        private EllipseConstraint ellipse;

        public BranchGenerator(FractalParameters parameters, RandomProvider random, EllipseConstraint ellipse)
        {
            this.parameters = parameters;
            this.random = random;
            this.ellipse = ellipse;
        }

        public List<Branch> GenerateChildren(Branch parent)
        {
            List<Branch> children = new List<Branch>();

            if(parent.Depth >= parameters.MaxDepth)
            {
                return children;
            }

            float dx = parent.End.X - parent.Start.X;
            float dy = parent.End.Y - parent.Start.Y;

            float length = (float)Math.Sqrt(dx * dx + dy * dy);
            float newLength = length * parameters.ReductionFactor;

            for(int i = -1; i <= 1; i++)
            {
                if(!random.Chance(parameters.BranchProbability))
                {
                    continue;
                }

                float angle = (float)Math.Atan2(dy, dx) + i * 0.5f;

                PointF newEnd = new PointF(
                    parent.End.X + newLength * (float)Math.Cos(angle),
                    parent.End.Y + newLength * (float)Math.Sin(angle)
                );

                if(!ellipse.IsInside(newEnd))
                {
                    continue;
                }

                children.Add(new Branch(parent.End, newEnd, parent.Depth + 1));
            }

            return children;
        }
    }
}
