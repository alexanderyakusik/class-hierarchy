using System;

namespace graphics_editor
{
    class ShapeParameters
    {
        public int minX { get; private set; }
        public int minY { get; private set; }
        public int maxX { get; private set; }
        public int maxY { get; private set; }
        public int deltaX { get; private set; }
        public int deltaY { get; private set; }
        public int minSide { get; private set; }

        public ShapeParameters(Shape shape)
        {
            minX = Math.Min(shape.X, shape.EndX);
            minY = Math.Min(shape.Y, shape.EndY);
            maxX = Math.Max(shape.X, shape.EndX);
            maxY = Math.Max(shape.Y, shape.EndY);
            deltaX = Math.Abs(shape.EndX - shape.X);
            deltaY = Math.Abs(shape.EndY - shape.Y);
            minSide = Math.Min(deltaX, deltaY);
        }
    }
}
