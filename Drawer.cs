﻿using System;
using System.Drawing;

namespace graphics_editor
{
    public static class Drawer
    {
        private static Shape currentShape;
        public static Type CurrentShapeType { get; set; }

        public static void DrawAllShapes(Graphics g, Pen pen)
        {
            ShapesList.Shapes.ForEach(item => item.Draw(g, pen));
        }

        public static void CreateCurrentShape(int x, int y)
        {
            currentShape = (Shape)Activator.CreateInstance(CurrentShapeType);
            currentShape.X = x;
            currentShape.Y = y;
            ShapesList.Add(currentShape);
        }

        public static void SetCurrentShapeCoordinates(int x, int y)
        {
            currentShape.X = x;
            currentShape.Y = y;
        }
    }
}
