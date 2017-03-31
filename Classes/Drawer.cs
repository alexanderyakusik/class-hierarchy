using System;
using System.Drawing;

namespace graphics_editor
{
    public static class Drawer
    {
        private static Shape currentDrawingShape;
        private static int initialMouseEditingX;
        private static int initialMouseEditingY;
        private static int initialShapeEditingX;
        private static int initialShapeEditingY;
        private static int initialShapeEditingEndX;
        private static int initialShapeEditingEndY;

        public static Type CurrentDrawingShapeType { get; set; }
        public static int ShapeNumber { get; private set; } = 1; 

        public static void DrawAllShapes(Graphics g, Pen pen)
        {
            ShapesList.Shapes.ForEach((Shape shape) => shape.Draw(g, pen));
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

        public static void RecalculateShapeProperties(Shape shape)
        {
            shape.RecalculateProperties();
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

        public static void SetInitialEditingCoordinates(Shape shape, int x, int y)
        {
            initialShapeEditingX = shape.X;
            initialShapeEditingY = shape.Y;
            initialShapeEditingEndX = shape.EndX;
            initialShapeEditingEndY = shape.EndY;
            initialMouseEditingX = x;
            initialMouseEditingY = y;
        }

        public static void ChangeShapeCoordinates(Shape shape, int x, int y)
        {
            shape.X = initialShapeEditingX + x - initialMouseEditingX;
            shape.EndX = initialShapeEditingEndX + x - initialMouseEditingX;
            shape.Y = initialShapeEditingY + y - initialMouseEditingY;
            shape.EndY = initialShapeEditingEndY + y - initialMouseEditingY;
        }
    }
}
