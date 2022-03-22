namespace Laba3_4.Drawers
{
    internal class RectangleDrawer : IDrawer
    {
        public void Draw(Graphics g, Pen pen, int x, int y)
        {
            g.DrawRectangle(pen, x, y, 50, 100);
        }
    }
}
