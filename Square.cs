using System;
using System.Drawing;

namespace graphics_editor
{
    public class Square : Rectangle 
    {
        public override void Draw(Graphics g, Pen pen)
        {
            if (Math.Abs(EndX - X) < Math.Abs(EndY - Y))
            {
                g.DrawRectangle(pen, Math.Min(X, EndX), Math.Min(X, EndX), Math.Max(X, EndX), Math.Max(X, EndX));
            }
            else
            {
                g.DrawRectangle(pen, Math.Min(Y, EndY), Math.Min(Y, EndY), Math.Max(Y, EndY), Math.Max(Y, EndY));
            }
        }
    }
}
