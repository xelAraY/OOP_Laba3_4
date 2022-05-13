namespace Laba3_4.Drawers
{
    internal class LineDrawer : IDrawer
    {
        public void Draw(Graphics g, Pen pen, int x1, int y1, int x2, int y2)
        {
            g.DrawLine(pen, x1, y1, x2, y2);
        }
    }
}
