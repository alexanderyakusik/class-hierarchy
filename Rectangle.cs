using System.Drawing;

namespace graphics_editor
{
    public class Rectangle : Shape
    {
        public int Width { get; }
        public int Height { get; }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawRectangle(pen, X, Y, Width, Height);
        }
    }
}
