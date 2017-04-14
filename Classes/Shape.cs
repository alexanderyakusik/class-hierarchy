using System;
using System.Drawing;

namespace graphics_editor
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int EndX { get; set; }
        public int EndY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }
        public int BorderWidth { get; set; }
        public string BorderColor { get; set; }

        protected struct ShapeParameters
        {
            public int minX, minY, maxX, maxY, deltaX, deltaY, minSide;
        }

        public abstract void Draw(Graphics g, Pen pen);
        public abstract void RecalculateProperties();

        protected ShapeParameters CalculateShapeParams()
        { 
            ShapeParameters shapeParams;
            shapeParams.minX = Math.Min(X, EndX);
            shapeParams.minY = Math.Min(Y, EndY);
            shapeParams.maxX = Math.Max(X, EndX);
            shapeParams.maxY = Math.Max(Y, EndY);
            shapeParams.deltaX = Math.Abs(EndX - X);
            shapeParams.deltaY = Math.Abs(EndY - Y);
            shapeParams.minSide = Math.Min(shapeParams.deltaX, shapeParams.deltaY);

            return shapeParams;
        }
    }
}
