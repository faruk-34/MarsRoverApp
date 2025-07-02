namespace MarsRoverApp
{
    public class Plateau
    {
        public int MaxX { get; }
        public int MaxY { get; }
        public Plateau(int maxX, int maxY)
        {
            MaxX = maxX;
            MaxY = maxY;
        }
        public (int x, int y) ClampPosition(int x, int y)
        {
            x = Math.Max(0, Math.Min(MaxX, x));
            y = Math.Max(0, Math.Min(MaxY, y));
            return (x, y);
        }
    }
}
