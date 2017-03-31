using System.Windows.Forms;
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
            InitializeShapeBorderWidthComboBoxItems();
            InitializeShapeBorderColorComboBoxItems();
            ShapesListBox.DisplayMember = "Name";
        }

        private void InitializeShapeBorderWidthComboBoxItems()
        {
            for (int i = 1; i <= 10; i++)
            {
                ShapeBorderWidthComboBox.Items.Add(i);
            }
            ShapeBorderWidthComboBox.SelectedIndex = 0;
        }

        private void InitializeShapeBorderColorComboBoxItems()
        {
            ShapeBorderColorComboBox.Items.Add(Color.Black);
            ShapeBorderColorComboBox.Items.Add(Color.Red);
            ShapeBorderColorComboBox.Items.Add(Color.Blue);
            ShapeBorderColorComboBox.Items.Add(Color.Green);

            ShapeBorderColorComboBox.SelectedIndex = 0;
        }

        private void RefreshShapesListBox()
        {
            ShapesListBox.Items.Clear();
            ShapesList.Shapes.ForEach((Shape shape) => ShapesListBox.Items.Add(shape));
        }

        private void PaintPictureBox(Graphics g)
        {
            var shapePen = new Pen(Color.Black);
            Drawer.DrawAllShapes(g, shapePen);
        }

        private void ClearPictureBox(Bitmap bmp)
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
            }
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bmp = new Bitmap(PictureBox.Width, PictureBox.Height);
            ClearPictureBox(bmp);
            PictureBox.Image = bmp;
            using (Graphics g = Graphics.FromImage(PictureBox.Image))
            {
                PaintPictureBox(g);
            }
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (Drawer.CurrentDrawingShapeType == null)
            {
                return;
            }

            isMouseDown = true;

            if (ShapesListBox.SelectedIndex != -1)
            {
                if ((Shape)ShapesListBox.SelectedItem is IEditable)
                {
                    Drawer.SetInitialEditingCoordinates((Shape)ShapesListBox.SelectedItem, e.X, e.Y);
                }
            }
            else
            {
                Drawer.CreateShape(e.X, e.Y);
                Drawer.SetShapeCoordinates(e.X, e.Y);
            }
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouseDown)
            {
                return;
            }

            if (ShapesListBox.SelectedIndex != -1)
            {
                if ((Shape)ShapesListBox.SelectedItem is IEditable)
                {
                    Drawer.ChangeShapeCoordinates((Shape)ShapesListBox.SelectedItem, e.X, e.Y);
                }
            }
            else
            {
                Drawer.SetShapeCoordinates(e.X, e.Y);
            }

            MainForm_Paint(sender, null);
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (Drawer.CurrentDrawingShapeType == null)
            {
                return;
            }

            isMouseDown = false;

            if (ShapesListBox.SelectedIndex == -1)
            {
                Drawer.RecalculateShapeProperties();
                Drawer.DeleteShapeIfEmpty();
                RefreshShapesListBox();
            }
            else
            {
                SelectShape((Shape)ShapesListBox.SelectedItem);
            }
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
                    if (shapesFile != null)
                    {
                        shapesFile.Close();
                    }

                    if (typesFile != null)
                    {
                        typesFile.Close();
                    }
                    Drawer.ChangeShapeNumber();
                    RefreshShapesListBox();
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
                    if (shapesFile != null)
                    {
                        shapesFile.Close();
                    }

                    if (typesFile != null)
                    {
                        typesFile.Close();
                    }
                }
            }
        }

        private void LineRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            Drawer.CurrentDrawingShapeType = typeof(Line);
        }

        private void RectangleRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            Drawer.CurrentDrawingShapeType = typeof(Rectangle);
        }

        private void SquareRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            Drawer.CurrentDrawingShapeType = typeof(Square);
        }

        private void EllipseRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            Drawer.CurrentDrawingShapeType = typeof(Ellipse);
        }

        private void CircleRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            Drawer.CurrentDrawingShapeType = typeof(Circle);
        }

        private void ButtonClearSelection_Click(object sender, System.EventArgs e)
        {
            ShapesListBox.ClearSelected();
        }

        private void SelectShape(Shape shape)
        {
            if (shape is ISelectable)
            {
                Bitmap bmp = new Bitmap(PictureBox.Width, PictureBox.Height);
                ClearPictureBox(bmp);
                PictureBox.Image = bmp;
                using (Graphics g = Graphics.FromImage(PictureBox.Image))
                {
                    PaintPictureBox(g);
                    ISelectable selectedShape = shape as ISelectable;
                    selectedShape.Select(g);
                }
            }
            else
            {
                MainForm_Paint(shape, null);
            }
        }

        private void SetRadioButtonsState(bool newState)
        {
            CircleRadioButton.Enabled = EllipseRadioButton.Enabled = SquareRadioButton.Enabled = 
                RectangleRadioButton.Enabled = LineRadioButton.Enabled = newState;
        }

        private void ShapesListBox_SelectedValueChanged(object sender, System.EventArgs e)
        {
            if (((ListBox)sender).SelectedItem == null)
            {
                MainForm_Paint(sender, null);
                PictureBox.Cursor = Cursors.Arrow;
                SetRadioButtonsState(true);
            }
            else
            {
                SelectShape(((Shape)((ListBox)sender).SelectedItem));
                PictureBox.Cursor = Cursors.Hand;
                SetRadioButtonsState(false);
            }
        }
    }
}
