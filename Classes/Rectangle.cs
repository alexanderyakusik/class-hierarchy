using System;
using System.Drawing;

namespace graphics_editor
{
    public class Rectangle : IrregularShape, IEditable, ISelectable
    {
        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawRectangle(pen, Math.Min(X, EndX), Math.Min(Y, EndY), Math.Abs(EndX - X), Math.Abs(EndY - Y));
        }

        public void Select(Graphics g)
        {
            var pen = new Pen(Color.OrangeRed);
            pen.Width = 2;
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pen.DashPattern = new float[] { 10.0F, 5.0F };
            g.DrawRectangle(pen, X, Y, Width, Height);
        }
    }
}
