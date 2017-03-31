using System;
using System.Drawing;

namespace graphics_editor
{
    public class Rectangle : IrregularShape, IEditable
    {
        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawRectangle(pen, Math.Min(X, EndX), Math.Min(Y, EndY), Math.Abs(EndX - X), Math.Abs(EndY - Y));
        }
    }
}
