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
                    g.DrawEllipse(pen, parameters.minX, parameters.minY, parameters.maxX, parameters.minX + parameters.deltaX);
                }
                else
                {
                    g.DrawEllipse(pen, parameters.minX, parameters.maxY - parameters.deltaX, parameters.maxX, parameters.maxY);
                }
            }
            else
            {
                if (X == parameters.minX)
                {
                    g.DrawEllipse(pen, parameters.minX, parameters.minY, parameters.minX + parameters.deltaY, parameters.maxY);
                }
                else
                {
                    g.DrawEllipse(pen, parameters.maxX - parameters.deltaY, parameters.minY, parameters.maxX, parameters.maxY);
                }
            }
        }
    }
}
