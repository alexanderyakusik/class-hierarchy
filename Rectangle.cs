using System;
using System.Drawing;

namespace graphics_editor
{
    public class Rectangle : Shape
    {
        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawRectangle(pen, Math.Min(X, EndX), Math.Min(Y, EndY), Math.Max(X, EndX), Math.Max(X, EndX));
        }
    }
}
