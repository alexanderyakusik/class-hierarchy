using System;
using System.Drawing;

namespace graphics_editor
{
    public class Ellipse : Shape
    {
        public int Width { get; protected set; }
        public int Height { get; protected set; }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawEllipse(pen, Math.Min(X, EndX), Math.Min(Y, EndY), Math.Max(X, EndX), Math.Max(X, EndX));
        }

        public override void RecalculateProperties()
        {
            var minX = Math.Min(X, EndX);
            var maxX = Math.Max(X, EndX);
            var minY = Math.Min(Y, EndY);
            var maxY = Math.Max(Y, EndY);
            X = minX;
            EndX = maxX;
            Y = minY;
            EndY = maxY;

            Width = Math.Abs(EndX - X);
            Height = Math.Abs(EndY - Y);
        }
    }
}
