using System.Windows.Forms;
using System.Drawing;

namespace class_hierarchy
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, System.EventArgs e)
        {
            var shapesList = new ShapesList();
            shapesList.Add(new Square(60, 0, 20));
            shapesList.Add(new Line(40, 30, 100, 30));
            shapesList.Add(new Dot(40, 40));
            shapesList.Add(new Dot(100, 40));
            shapesList.Add(new Rectangle(60, 40, 20, 10));
            shapesList.Add(new Circle(25, 40, 5));
            shapesList.Add(new Circle(115, 40, 5));
            shapesList.Add(new Ellipse(50, 60, 40, 10));

            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
            }
            pictureBox.Image = bmp;
            using (Graphics g = Graphics.FromImage(pictureBox.Image))
            {
                var brush = new SolidBrush(Color.Black);
                shapesList.DrawAllShapes(g, brush);
            }
            pictureBox.Invalidate();
        }
    }
}
