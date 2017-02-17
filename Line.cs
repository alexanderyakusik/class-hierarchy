using System.Drawing;

namespace class_hierarchy
{
    public class Line : Dot
    {
        public int end_x { get; }
        public int end_y { get; }

        public Line(int x, int y, int end_x, int end_y) : base(x, y)
        {
            this.end_x = end_x;
            this.end_y = end_y;
        }

        public override void Draw(Graphics g, Brush brush)
        {
            using (var pen = new Pen(brush))
            {
                g.DrawLine(pen, x, y, end_x, end_y);
            }
        }
    }
}
