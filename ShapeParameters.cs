using System;

namespace graphics_editor
{
    class ShapeParameters
    {
        public int minX { get; }
        public int minY { get; }
        public int maxX { get; }
        public int maxY { get; }
        public int deltaX { get; }
        public int deltaY { get; }
        public int minSide { get; }

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
