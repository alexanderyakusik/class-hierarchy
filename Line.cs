using System.Drawing;

namespace class_hierarchy
{
    public class Line : Shape
    {
        public int EndX { get; }
        public int EndY { get; }

        public Line(int x, int y, int end_x, int end_y) : base(x, y)
        {
            EndX = end_x;
            EndY = end_y;
        }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawLine(pen, X, Y, EndX, EndY);
        }
    }
}
