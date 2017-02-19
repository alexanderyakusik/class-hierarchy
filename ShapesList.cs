using System.Collections.Generic;
using System.Drawing;

namespace class_hierarchy
{
    static class ShapesList
    {
        private static List<Shape> shapes = new List<Shape>();

        public static void Add(Shape shape)
        {
            shapes.Add(shape);
        }

        public static void DrawAllShapes(Graphics g, Brush brush)
        {
            shapes.ForEach(item => item.Draw(g, brush));
        }
    }
}
