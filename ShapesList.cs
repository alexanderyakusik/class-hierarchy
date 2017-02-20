using System.Collections.Generic;
using System.Drawing;

namespace class_hierarchy
{
    static class ShapesList
    {
        private static List<Shape> shapes = new List<Shape>();
        public static Shape[] availableShapes { get; } = {
            new Dot(0, 0),
            new Line(0, 0, 0, 0),
            new Rectangle(0, 0, 0, 0),
            new Square(0, 0, 0),
            new Ellipse(0, 0, 0, 0),
            new Circle(0, 0, 0)
        };

        public static Shape currentShape { get; set; } = null;

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
