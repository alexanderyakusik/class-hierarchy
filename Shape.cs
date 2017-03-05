using System.Drawing;

namespace graphics_editor
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int EndX { get; set; }
        public int EndY { get; set; }
        public int Width { get; protected set; }
        public int Height { get; protected set; }

        public abstract void Draw(Graphics g, Pen pen);

        public virtual void RecalculateProperties()
        {
            var shapeParameters = new ShapeParameters(this);

            Height = shapeParameters.deltaX;
            Width = shapeParameters.deltaY;
            X = shapeParameters.minX;
            EndX = shapeParameters.maxX;
            Y = shapeParameters.minY;
            EndY = shapeParameters.maxY;
        }
    }
}
