using Laba3_4.Drawers;
using Shapes;

namespace Laba3_4
{
    public partial class MainForm : Form
    {
        Pen pen = new Pen(Color.Black);
        Dictionary<string, IDrawer> shapesDrawers = new Dictionary<string, IDrawer>()
        {
            {"Rectangle", new RectangleDrawer()},
            {"Circle", new CircleDrawer()},
            {"Square", new SquareDrawer()},
            {"Line", new LineDrawer()},
            {"Ellipse", new EllipseDrawer()},
            {"Triangle", new TriangleDrawer()}
        };
        ShapesList list = new ShapesList();

        public MainForm()
        {
            InitializeComponent();
            colorDialog1.FullOpen = true;
        }

        private void ColorSelect_Button_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pen.Color = colorDialog1.Color;
            else
                return;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            list.Add(Figure_ComboBox.Text);

            foreach (var shape in shapesDrawers)
            {
                if(shape.Key == list[list.Count - 1])
                {
                    shape.Value.Draw(g, pen, e.X, e.Y);
                    break;
                }
            }           
            g.Dispose();
        }
    }
}