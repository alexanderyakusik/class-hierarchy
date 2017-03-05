using System.Drawing;

namespace graphics_editor
{
    public class Line : Shape
    {
        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawLine(pen, X, Y, EndX, EndY);
        }
    }
}
