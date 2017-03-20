using System;
using System.Drawing;

namespace graphics_editor
{
    public static class Drawer
    {
        private static int shapeNumber = 1;
        private static Shape currentDrawingShape;
        public static Type CurrentDrawingShapeType { get; set; }

        public static void DrawAllShapes(Graphics g, Pen pen)
        {
            ShapesList.Shapes.ForEach(item => item.Draw(g, pen));
        }

        public static void CreateShape(int x, int y)
        {
            currentDrawingShape = (Shape)Activator.CreateInstance(CurrentDrawingShapeType);
            currentDrawingShape.X = x;
            currentDrawingShape.Y = y;
            currentDrawingShape.Name = "Shape" + Convert.ToString(shapeNumber++);
            ShapesList.Add(currentDrawingShape);
        }

        public static void SetShapeCoordinates(int x, int y)
        {
            currentDrawingShape.EndX = x;
            currentDrawingShape.EndY = y;
        }

        public static void RecalculateShapeProperties()
        {
            currentDrawingShape.RecalculateProperties();
        }
    }
}
