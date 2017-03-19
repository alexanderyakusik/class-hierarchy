using System.Collections.Generic;

namespace graphics_editor
{
    static class ShapesList
    {
        public static List<Shape> Shapes { get; } = new List<Shape>();

        public static Shape currentShape { get; set; }

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
