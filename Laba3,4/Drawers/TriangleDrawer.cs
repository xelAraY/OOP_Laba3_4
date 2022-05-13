namespace Laba3_4.Drawers
{
    internal class TriangleDrawer : IDrawer
    {
        public void Draw(Graphics g, Pen pen, int x1, int y1, int x2, int y2)
        {
            Point[] points = { new Point(x1, y2),
                               new Point((x2-x1)/2+x1, y1),
                               new Point(x2, y2)
            };
            g.DrawPolygon(pen, points);
        }
    }
}
