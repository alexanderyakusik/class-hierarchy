using System.Collections.Generic;
using System.Drawing;

namespace class_hierarchy
{
    class ShapesList
    {
        private List<Shape> shapes;

        public ShapesList()
        {
            shapes = new List<Shape>();
        }

        public void Add(Shape shape)
        {
            shapes.Add(shape);
        }

        public void DrawAllShapes(Graphics g, Brush brush)
        {
            shapes.ForEach(item => item.Draw(g, brush));
        }
    }
}
