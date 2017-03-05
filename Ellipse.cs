using System;
using System.Drawing;

namespace graphics_editor
{
    public class Ellipse : Shape
    {
        public int Width { get; }
        public int Height { get; }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawEllipse(pen, Math.Min(X, EndX), Math.Min(Y, EndY), Math.Max(X, EndX), Math.Max(X, EndX));
        }
    }
}
