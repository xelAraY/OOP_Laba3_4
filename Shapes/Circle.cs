using System.Drawing;
using System;

namespace Shapes
{
    public class Circle : BaseShape
    {
        public int Radius { get; set; }
        public Circle(string name, int x1, int y1, int x2, int y2, bool selected, Color color): 
            base(name, x1, y1, x2, y2, selected, color)
        {
            Radius = Math.Abs(x2 - x1)/2;
        }
    }
}
