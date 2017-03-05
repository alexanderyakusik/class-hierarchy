using System.Drawing;

namespace graphics_editor
{
    public static class Drawer
    {
        private static Shape currentShape;

        public static void DrawAllShapes(Graphics g, Pen pen)
        {
            ShapesList.Shapes.ForEach(item => item.Draw(g, pen));
        }
    }
}
