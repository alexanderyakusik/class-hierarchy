using System.Drawing;

namespace graphics_editor
{
    public class Circle : Ellipse
    {
        public override void Draw(Graphics g, Pen pen)
        {
            var parameters = new ShapeParameters(this);

            if (parameters.deltaX < parameters.deltaY)
            {
                if (Y == parameters.minY)
                {
                    g.DrawEllipse(pen, parameters.minX, parameters.minY, parameters.deltaX, parameters.deltaX);
                }
                else
                {
                    g.DrawEllipse(pen, parameters.minX, parameters.maxY - parameters.deltaX, parameters.deltaX, parameters.deltaX);
                }
            }
            else
            {
                if (X == parameters.minX)
                {
                    g.DrawEllipse(pen, parameters.minX, parameters.minY, parameters.deltaY, parameters.deltaY);
                }
                else
                {
                    g.DrawEllipse(pen, parameters.maxX - parameters.deltaY, parameters.minY, parameters.deltaY, parameters.deltaY);
                }
            }
        }
    }
}
