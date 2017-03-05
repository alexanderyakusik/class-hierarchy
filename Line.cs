using System.Drawing;

namespace class_hierarchy
{
    public class Line : Shape
    {
        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawLine(pen, X, Y, EndX, EndY);
        }
    }
}
