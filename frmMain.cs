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

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
            }
            pictureBox.Image = bmp;
            using (Graphics g = Graphics.FromImage(pictureBox.Image))
            {
                var pen = new Pen(new SolidBrush(Color.Black));
                ShapesList.DrawAllShapes(g, pen);
            }
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripButton btn in ((ToolStrip)sender).Items)
            {
                if (btn != e.ClickedItem) btn.Checked = false;
            }
        }
    }
}
