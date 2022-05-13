using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : BaseShape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(string name, int x1, int y1, int x2, int y2, bool selected, Color color) : 
            base(name, x1, y1, x2, y2, selected, color)
        {
            Width = Math.Abs(x2 - x1);
            Height = Math.Abs(y2 - y1);
        }
    }
}
