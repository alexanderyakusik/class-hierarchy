using System;
using System.Drawing;

namespace graphics_editor
{
    public static class Drawer
    {
        private static Shape currentDrawingShape;

        public static Type CurrentDrawingShapeType { get; set; }
        public static int ShapeNumber { get; private set; } = 1;

        public static void DrawAllShapes(Graphics g, Pen pen)
        {
            foreach (Shape shape in ShapesList.Shapes)
            {
                shape.Draw(g, pen);
            }
        }

        public static void CreateShape(int x, int y)
        {
            currentDrawingShape = (Shape)Activator.CreateInstance(CurrentDrawingShapeType);
            currentDrawingShape.X = x;
            currentDrawingShape.Y = y;
            currentDrawingShape.Name = "Фигура" + Convert.ToString(ShapeNumber++);
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

        public static void DeleteShapeIfEmpty()
        {
            if (currentDrawingShape.X == currentDrawingShape.EndX && 
                currentDrawingShape.Y == currentDrawingShape.EndY)
            {
                ShapesList.DeleteLastShape();
                ShapeNumber--;
            }
        }

        public static void ChangeShapeNumber()
        {
            ShapeNumber = ShapesList.Shapes.Count + 1;
        }
    }
}
