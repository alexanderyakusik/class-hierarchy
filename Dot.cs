using System.Drawing;

namespace class_hierarchy
{
    public class Dot : Shape
    {
        public Dot(int x, int y) : base(x, y) { }

        public override void Draw(Graphics g, Brush brush)
        {
            g.FillRectangle(brush, x, y, 1, 1);
        }
    }
}
