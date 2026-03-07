using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals.Utilities
{
    public class Branch
    {
        public PointF Start { get; }
        public PointF End { get; }
        public int Depth { get; }

        public Branch(PointF start, PointF end, int depth)
        {
            Start = start;
            End = end;
            Depth = depth;
        }
    }
}
