namespace Langston_s_Ant.Domain
{
    public class SquareGrid : IGrid
    {
        private readonly int[,] cells;

        public int Width { get; }
        public int Height { get; }

        public SquareGrid(int w, int h)
        {
            Width = w;
            Height = h;
            cells = new int[w, h];
        }

        public int GetState(int x, int y) => cells[x, y];
        public void SetState(int x, int y, int state) => cells[x, y] = state;
    } 
}
