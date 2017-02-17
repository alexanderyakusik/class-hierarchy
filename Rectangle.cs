using System.Drawing;

namespace class_hierarchy
{
    public class Rectangle : Dot
    {
        public int width { get; }
        public int height { get; }

        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            this.width = width;
            this.height = height;
        }

        public override void Draw(Graphics g, Brush brush)
        {
            using (var pen = new Pen(brush))
            {
                g.DrawRectangle(pen, x, y, width, height);
            }
        }
    }
}
