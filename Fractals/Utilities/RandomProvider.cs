using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals.Utilities
{
    public class RandomProvider
    {
        private Random random = new Random();

        public bool Chance(float probability)
        {
            return random.NextDouble() < probability;
        }

        public float Range(float min, float max)
        {
            return (float)(min + random.NextDouble() * (max - min));
        }
    }
}
