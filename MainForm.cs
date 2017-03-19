﻿using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace graphics_editor
{
    public partial class MainForm : Form
    {
        private bool isMouseDown;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bmp = new Bitmap(PictureBox.Width, PictureBox.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
            }
            PictureBox.Image = bmp;
            using (Graphics g = Graphics.FromImage(PictureBox.Image))
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

        private void ToolStripButtonLine_Click(object sender, System.EventArgs e)
        {
            Drawer.CurrentShapeType = typeof(Line);
        }

        private void ToolStripButtonRectangle_Click(object sender, System.EventArgs e)
        {
            Drawer.CurrentShapeType = typeof(Rectangle);
        }

        private void ToolStripButtonSquare_Click(object sender, System.EventArgs e)
        {
            Drawer.CurrentShapeType = typeof(Square);
        }

        private void ToolStripButtonEllipse_Click(object sender, System.EventArgs e)
        {
            Drawer.CurrentShapeType = typeof(Ellipse);
        }

        private void ToolStripButtonCircle_Click(object sender, System.EventArgs e)
        {
            Drawer.CurrentShapeType = typeof(Circle);
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (Drawer.CurrentShapeType == null) return;
            isMouseDown = true;
            Drawer.CreateShape(e.X, e.Y);
            Drawer.SetShapeCoordinates(e.X, e.Y);
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouseDown) return;
            Drawer.SetShapeCoordinates(e.X, e.Y);
            MainForm_Paint(sender, null);
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (Drawer.CurrentShapeType == null) return;
            isMouseDown = false;
            Drawer.RecalculateShapeProperties();
        }

        private void LoadToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream shapesFile = null;
                StreamReader typesFile = null;
                try
                {
                    shapesFile = new FileStream(FolderBrowserDialog.SelectedPath + "/Project.xml", FileMode.Open);
                    typesFile = new StreamReader(FolderBrowserDialog.SelectedPath + "/Project.types");
                    ProjectManager.LoadShapes(shapesFile, typesFile);
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("Ошибка! В данной директории нет файлов проекта.", "Ошибка!");
                }
                finally
                {
                    MainForm_Paint(sender, null);
                    if (shapesFile != null) shapesFile.Close();
                    if (typesFile != null) typesFile.Close();
                }
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var shapesFile = new FileStream(FolderBrowserDialog.SelectedPath + "/Project.xml", FileMode.Create);
                var typesFile = new StreamWriter(FolderBrowserDialog.SelectedPath + "/Project.types");
                try
                {
                    ProjectManager.SaveShapes(shapesFile, typesFile);
                }
                finally
                {
                    if (shapesFile != null) shapesFile.Close();
                    if (typesFile != null) typesFile.Close();
                }
            }
        }
    }
}
