namespace Laba3_4.Drawers
{
    internal class CircleDrawer : IDrawer
    {
        public void Draw(Graphics g, Pen pen, int x, int y)
        {
            g.DrawEllipse(pen, x, y, 50, 50);
        }
    }
}
