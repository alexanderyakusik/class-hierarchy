using System.Drawing;

namespace class_hierarchy
{
    public class Ellipse : Shape
    {
        public int Width { get; }
        public int Height { get; }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawEllipse(pen, X, Y, Width, Height);
        }
    }
}
