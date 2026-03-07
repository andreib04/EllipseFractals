using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals.Utilities
{
    public class FractalEngine
    {
        private BranchGenerator generator;

        public FractalEngine(BranchGenerator generator)
        {
            this.generator = generator;
        }

        public List<Branch> Generate(List<Branch> roots)
        {
            List<Branch> result = new List<Branch>();
            Queue<Branch> queue = new Queue<Branch>(roots);

            while(queue.Count > 0)
            {
                Branch b = queue.Dequeue();
                result.Add(b);

                foreach (var child in generator.GenerateChildren(b))
                {
                    queue.Enqueue(child);
                }
            }

            return result;
        }
    }
}
