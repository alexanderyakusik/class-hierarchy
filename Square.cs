using System;
using System.Drawing;

namespace graphics_editor
{
    public class Square : Rectangle 
    {
        public override void Draw(Graphics g, Pen pen)
        {
            var minX = Math.Min(X, EndX);
            var minY = Math.Min(Y, EndY);
            var maxX = Math.Max(X, EndX);
            var maxY = Math.Max(Y, EndY);
            var deltaX = Math.Abs(EndX - X);
            var deltaY = Math.Abs(EndY - Y);
            if (deltaX < deltaY)
            {
                if (Y == minY)
                {
                    g.DrawRectangle(pen, minX, minY, maxX, minX + deltaX);
                }
                else
                {
                    g.DrawRectangle(pen, minX, maxY - deltaX, maxX, maxY);
                }
            }
            else
            {
                if (X == minX)
                {
                    g.DrawRectangle(pen, minX, minY, minX + deltaY, maxY);
                }
                else
                {
                    g.DrawRectangle(pen, maxX - deltaY, minY, maxX, maxY);
                }
            }
        }
    }
}
