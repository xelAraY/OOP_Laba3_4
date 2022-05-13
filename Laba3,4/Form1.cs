using Laba3_4.Drawers;
using Shapes;
using System.Runtime.Serialization.Formatters.Binary;

namespace Laba3_4
{
    [Serializable]
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
        ShapesList shapesList = new ShapesList();
        private bool select = false;
        private int clickCount = 0;
        private int startX = 0;
        private int startY = 0;

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

            Graphics g = pictureBox1.CreateGraphics();

            foreach (var shape in shapesList)
            {
                if (shape.Selected == true)
                {
                    shape.color = pen.Color;
                    foreach (var drawer in shapesDrawers)
                    {
                        if (drawer.Key == shape.Name)
                        {
                            drawer.Value.Draw(g, new Pen(shape.color), shape.X1, shape.Y1, shape.X2, shape.Y2);
                            break;
                        }
                    }
                }
                    
            }
            g.Dispose();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (!select)
                clickCount++;

            if (clickCount % 2 != 0 && !select)
            {               
                startX = e.X;
                startY = e.Y;
                return;
            }

            Graphics g = pictureBox1.CreateGraphics();

            if (select && typeof(ISelectable).IsAssignableFrom(typeof(BaseShape)))
            {
                foreach (var shape in shapesList)
                {
                    if (((e.X >= shape.X1 && e.X <= shape.X2) || (e.X >= shape.X2 && e.X <= shape.X1)) && 
                        (e.Y >= shape.Y1 && e.Y <= shape.Y2))
                    {
                        Pen pen = new Pen(Color.Red);
                        pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                        if (shape.Name != "Circle" || shape.Name != "Square")
                            g.DrawRectangle(pen, Math.Min(shape.X1, shape.X2), Math.Min(shape.Y1, shape.Y2), 
                                            Math.Abs(shape.X1 - shape.X2), Math.Abs(shape.Y1 - shape.Y2));                          
                        shape.Selected = true;
                        return;
                    }
                }
            }
            
            select = false;
            Redraw_Button_Click(sender, e);

            if (!select && clickCount % 2 == 0)
            {
                shapesList.Add(new BaseShape(Figure_ComboBox.Text, startX, startY, e.X, e.Y, false, pen.Color));
                foreach (var shape in shapesDrawers)
                {
                    if (shape.Key == shapesList[shapesList.Count - 1].Name)
                    {
                        shape.Value.Draw(g, pen, startX, startY, e.X, e.Y);
                        break;
                    }
                }
            }
                   
            g.Dispose();
        }

        private void Redraw_Button_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();

            foreach (var shape in shapesList)
            {
                shape.Selected = false;
                foreach (var drawer in shapesDrawers)
                {
                    if (drawer.Key == shape.Name)
                    {
                        drawer.Value.Draw(g, new Pen(shape.color), shape.X1, shape.Y1, shape.X2, shape.Y2);
                        break;
                    }
                }
            }
            g.Dispose();
        }

        private void SaveImage_Button_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("shapes.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, shapesList);
            }
        }

        private void OpenImage_Button_Click(object sender, EventArgs e)
        {
            ClearCanvas_Button_Click(sender, e);

            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("shapes.dat", FileMode.OpenOrCreate))
            {
                shapesList = (ShapesList)formatter.Deserialize(fs);
            }

            Redraw_Button_Click(sender, e);
        }

        private void SelectShape_Click(object sender, EventArgs e)
        {
            select = true;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            select = false;
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            Redraw_Button_Click(sender, e);
            g.Dispose();
        }

        private void ClearCanvas_Button_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            shapesList.Clear();
            clickCount = 0;
            g.Dispose();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (var shape in shapesList)
                {
                    if (shape.Selected == true)
                    {
                        shapesList.Remove(shape);
                        break;
                    }
                }
            }

            Cancel_Button_Click(sender, e);
        }
    }
}