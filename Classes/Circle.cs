using System.Drawing;

namespace graphics_editor
{
    public class Circle : RegularShape
    {
        public override void Draw(Graphics g, Pen pen)
        {
            ShapeParameters parameters = CalculateShapeParams();

            if (parameters.deltaX < parameters.deltaY)
            {
                if (Y == parameters.minY)
                {
                    g.DrawEllipse(pen, parameters.minX, parameters.minY, parameters.minSide, parameters.minSide);
                }
                else
                {
                    g.DrawEllipse(pen, parameters.minX, parameters.maxY - parameters.minSide, parameters.minSide, parameters.minSide);
                }
            }
            else
            {
                if (X == parameters.minX)
                {
                    g.DrawEllipse(pen, parameters.minX, parameters.minY, parameters.minSide, parameters.minSide);
                }
                else
                {
                    g.DrawEllipse(pen, parameters.maxX - parameters.minSide, parameters.minY, parameters.minSide, parameters.minSide);
                }
            }
        }
    }
}
