using System.Windows.Forms;
using System.Drawing;

namespace graphics_editor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
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
                Drawer.DrawAllShapes(g, pen);
            }
        }

        private void ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripButton btn in ((ToolStrip)sender).Items)
            {
                if (btn != e.ClickedItem) btn.Checked = false;
            }
        }
    }
}
