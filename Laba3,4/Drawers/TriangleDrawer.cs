namespace Laba3_4.Drawers
{
    internal class TriangleDrawer : IDrawer
    {
        public void Draw(Graphics g, Pen pen, int x, int y)
        {
            Point[] points = { new Point(x, y+50),
                               new Point(x+50, y+50),
                               new Point(x+25, y)
            };
            g.DrawPolygon(pen, points);
        }
    }
}
