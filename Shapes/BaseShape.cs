using Laba3_4;
using System;
using System.Drawing;

namespace Shapes
{
    [Serializable]
    public class BaseShape : ISelectable
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }  
        public int X2 { get; set; }
        public int Y2 { get; set; }

        public string Name { get; set; }

        public bool Selected { get; set; }

        public Color color { get; set; }

        public BaseShape(string name, int x1,int y1, int x2, int y2, bool selected, Color color)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            Name = name;
            Selected = selected;
            this.color = color;
        }
    }
}
