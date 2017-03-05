using System;
using System.Drawing;

namespace graphics_editor
{
    public class Circle : Ellipse
    {
        public override void Draw(Graphics g, Pen pen)
        {
            if (Math.Abs(EndX - X) < Math.Abs(EndY - Y))
            {
                g.DrawEllipse(pen, Math.Min(X, EndX), Math.Min(X, EndX), Math.Max(X, EndX), Math.Max(X, EndX));
            }
            else
            {
                g.DrawEllipse(pen, Math.Min(Y, EndY), Math.Min(Y, EndY), Math.Max(Y, EndY), Math.Max(Y, EndY));
            }
        }
    }
}
