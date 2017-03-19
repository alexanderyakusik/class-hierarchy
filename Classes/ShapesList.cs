using System.Collections.Generic;

namespace graphics_editor
{
    static class ShapesList
    {
        public static List<Shape> Shapes { get; set; } = new List<Shape>();

        public static Shape CurrentShape { get; set; }

        public static void Add(Shape shape)
        {
            Shapes.Add(shape);
        }

        public static void Clear()
        {
            Shapes.Clear();
        }
    }
}
