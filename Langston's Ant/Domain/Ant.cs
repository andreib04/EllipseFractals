namespace LangstonsAnt.Domain
{
    public class Ant
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Direction Direction { get; private set; }

        public Ant(int x, int y)
        {
            X = x;
            Y = y;
            Direction = Direction.Up;
        }

        public void TurnRight() => Direction = (Direction)(((int)Direction + 1) % 4);

        public void TurnLeft() => Direction = (Direction)(((int)Direction + 3) % 4);

        public void Move()
        {
            switch (Direction)
            {
                case Direction.Up:
                    Y--;
                    break;
                case Direction.Right:
                    X++;
                    break;
                case Direction.Down:
                    Y++;
                    break;
                case Direction.Left:
                    X--;
                    break;
            }
        }

        public void Wrap(int width, int height)
        {
            if (X < 0) X = width - 1;
            if (Y < 0) Y = height - 1;
            if (X >= width) X = 0;
            if (Y >= height) Y = 0;
        }
    }
}
