using System.Collections.Generic;

namespace Langston_s_Ant.Domain
{
    public class HexGrid : IGrid
    {
        private readonly Dictionary<(int, int), int> cells = new Dictionary<(int, int), int>();

        public int Width { get; }
        public int Height { get; }

        public HexGrid(int w, int h)
        {
            Width = w;
            Height = h;
        }

        public int GetState(int x, int y)
        {
            return cells.TryGetValue((x, y), out var val) ? val : 0;
        }

        public void SetState(int x, int y, int state)
        {
            cells[(x, y)] = state;
        }
    }
}
