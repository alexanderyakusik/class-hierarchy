using System.Collections.Generic;
using System.Drawing;

namespace class_hierarchy
{
    class ShapesList
    {
        private List<Dot> shapes;

        public ShapesList()
        {
            shapes = new List<Dot>();
        }

        public void Add(Dot shape)
        {
            shapes.Add(shape);
        }

        public void DrawShapes(Graphics g, Brush brush)
        {
            shapes.ForEach(item => item.Draw(g, brush));
        }
    }
}
