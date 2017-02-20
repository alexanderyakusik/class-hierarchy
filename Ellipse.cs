using System.Drawing;

namespace graphic_editor
{
    public class Ellipse : ComplexShape
    {
        public Ellipse(int x, int y, int width, int height) : base(x, y, width, height) { }

        public override void Draw(Graphics g, Brush brush)
        {
            RecalculateCoords();
            using (var pen = new Pen(brush))
            {
                g.DrawEllipse(pen, init_x, init_y, width, height);
            }
        }
    }
}
