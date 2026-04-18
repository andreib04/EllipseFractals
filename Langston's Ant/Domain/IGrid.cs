namespace Langston_s_Ant
{
    public interface IGrid
    {
        int Width { get; }
        int Height { get; }

        int GetState(int x, int y);
        void SetState(int x, int y, int state);
    }
}
