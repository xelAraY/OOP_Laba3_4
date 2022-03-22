namespace Laba3_4.Drawers
{
    internal class LineDrawer : IDrawer
    {
        public void Draw(Graphics g, Pen pen, int x, int y)
        {
            g.DrawLine(pen, x, y, x+100, y);
        }
    }
}
