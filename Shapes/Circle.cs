using System.Drawing;
using System;

namespace Shapes
{
    public class Circle : BaseShape
    {
        public int Radius { get; set; }
        public Circle(int x1, int y1, int x2, int y2): base(x1, y1, x2, y2)
        {
            Radius = Math.Abs(x2 - x1)/2;
        }
    }
}
