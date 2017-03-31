using System;
using System.Drawing;

namespace graphics_editor
{
    public class Ellipse : IrregularShape, ISelectable
    {
        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawEllipse(pen, Math.Min(X, EndX), Math.Min(Y, EndY), Math.Abs(EndX - X), Math.Abs(EndY - Y));
        }

        public void Select(Graphics g)
        {
            var pen = new Pen(Color.DarkGray);
            pen.Width = 3;
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pen.DashPattern = new float[] { 5.0F, 5.0F };
            g.DrawRectangle(pen, X, Y, Width, Height);
        }
    }
}
