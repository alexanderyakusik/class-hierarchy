using System.Drawing;

namespace class_hierarchy
{
    public class Ellipse : Dot
    {
        public int width { get; }
        public int height { get; }

        public Ellipse(int x, int y, int width, int height) : base(x, y)
        {
            this.width = width;
            this.height = height;
        }

        public override void Draw(Graphics g, Brush brush)
        {
            using (var pen = new Pen(brush))
            {
                g.DrawEllipse(pen, x, y, width, height);
            }
        }
    }
}
