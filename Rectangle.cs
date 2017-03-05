using System.Drawing;

namespace class_hierarchy
{
    public class Rectangle : Shape
    {
        public int Width { get; }
        public int Height { get; }

        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            Width = width;
            Height = height;
        }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawRectangle(pen, X, Y, Width, Height);
        }
    }
}
