using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : BaseShape
    {
        public int Side { get; set; }
        public Square(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2)
        {
            Side = Math.Abs(x2 - x1);
        }
    }
}
