using System.Windows.Forms;
using System.Drawing;

namespace graphic_editor
{
    public partial class frmMain : Form
    {
        public bool isMouseButtonPressed { get; set; }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            RepaintPictureBox();
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripButton btn in ((ToolStrip)sender).Items)
            {
                if (btn != e.ClickedItem)
                    btn.Checked = false;
                else
                    if (btn.Checked == false)
                        SetCurrentShape(btn);
                    else
                        ShapesList.currentShape = null;
            }
        }

        private void SetCurrentShape(ToolStripButton btn)
        {
            switch (btn.Name)
            {
                case "toolStripButtonPencil":
                    ShapesList.currentShape = ShapesList.availableShapes[0];
                    break;
                case "toolStripButtonLine":
                    ShapesList.currentShape = ShapesList.availableShapes[1];
                    break;
                case "toolStripButtonRectangle":
                    ShapesList.currentShape = ShapesList.availableShapes[2];
                    break;
                case "toolStripButtonSquare":
                    ShapesList.currentShape = ShapesList.availableShapes[3];
                    break;
                case "toolStripButtonEllipse":
                    ShapesList.currentShape = ShapesList.availableShapes[4];
                    break;
                case "toolStripButtonCircle":
                    ShapesList.currentShape = ShapesList.availableShapes[5];
                    break;
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (ShapesList.currentShape == null) return;
            ShapesList.Add(ShapesList.currentShape.Clone());
            ShapesList.currentShape = ShapesList.GetLastShape();
            ShapesList.currentShape.x = e.X;
            ShapesList.currentShape.y = e.Y;
            isMouseButtonPressed = true;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouseButtonPressed) return;
            ShapesList.currentShape.end_x = e.X;
            ShapesList.currentShape.end_y = e.Y;
            RepaintPictureBox();
        }

        private void RepaintPictureBox()
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
            }
            pictureBox.Image = bmp;
            using (Graphics g = Graphics.FromImage(pictureBox.Image))
            {
                var brush = new SolidBrush(Color.Black);
                ShapesList.DrawAllShapes(g, brush);
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseButtonPressed = false;
        }
    }
}
