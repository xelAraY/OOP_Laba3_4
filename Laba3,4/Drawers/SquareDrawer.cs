namespace Laba3_4.Drawers
{
    internal class SquareDrawer : IDrawer
    {
        public void Draw(Graphics g, Pen pen, int x1, int y1, int x2, int y2)
        {
            g.DrawRectangle(pen, Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x1 - x2), Math.Abs(y1 - y2));
        }
    }
}
