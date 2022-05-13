using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    public class Line : BaseShape
    {
        public Line(string name, int x1, int y1, int x2, int y2, bool selected, Color color) : 
            base(name, x1, y1, x2, y2, selected, color) { }   
    }
}
