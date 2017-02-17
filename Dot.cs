using System.Drawing;

namespace class_hierarchy
{
    public class Dot
    {
        public int x { get; }
        public int y { get; }

        public Dot(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual void Draw(Graphics g, Brush brush)
        {
            g.FillRectangle(brush, x, y, 1, 1);
        }
    }
}
