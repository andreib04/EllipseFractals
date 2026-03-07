using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals.Models
{
    public class FractalParameters
    {
        public int PolygonSides { get; set; }
        public PointF Center { get; set; }
        public float CircumscribedRadius { get; set; }
        public float ReductionFactor { get; set; }
        public int MaxDepth { get; set; }
        public float BranchProbability { get; set; }

        public float EllipseA  { get; set; }
        public float EllipseB { get; set; }
    }
}
