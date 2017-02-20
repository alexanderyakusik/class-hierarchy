using System.Drawing;

namespace graphic_editor
{
    public class Rectangle : ComplexShape
    {
        public Rectangle(int x, int y, int width, int height) : base(x, y, width, height) { }       

        public override void Draw(Graphics g, Brush brush)
        {
            RecalculateCoords();
            using (var pen = new Pen(brush))
            {
                g.DrawRectangle(pen, init_x, init_y, width, height);
            }
        }
    }
}
