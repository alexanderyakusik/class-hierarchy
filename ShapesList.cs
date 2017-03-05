using System.Collections.Generic;

namespace graphics_editor
{
    static class ShapesList
    {
        public static List<Shape> Shapes { get; }

        public static void Add(Shape shape)
        {
            Shapes.Add(shape);
        }
    }
}
