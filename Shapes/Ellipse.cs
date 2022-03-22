using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Ellipse : BaseShape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Ellipse(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2)
        {
            Width = Math.Abs(x2 - x1);
            Height = Math.Abs(y2 - y1);
        }
    }
}
