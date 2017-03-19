using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace graphics_editor
{
    public static class ProjectManager
    {
        private static Type[] GetShapesTypes()
        {
            return ShapesList.Shapes.Select((Shape item) => item.GetType()).ToArray();
        }

        public static void SaveShapes(FileStream shapesFile, StreamWriter typesFile)
        {
            Type[] types = GetShapesTypes();
            var xmlSerializer = new XmlSerializer(typeof(List<Shape>), types);

            typesFile.Write( String.Join(" ", types.Select((Type type) => type.ToString())) );
            xmlSerializer.Serialize(shapesFile, ShapesList.Shapes);
        }

        public static void LoadShapes(FileStream shapesFile, StreamReader typesFile)
        {
            Type[] types = typesFile.ReadLine().Split(' ').Select((String type) => Type.GetType(type)).ToArray();
            var xmlSerializer = new XmlSerializer(typeof(List<Shape>), types);

            ShapesList.Shapes = (List<Shape>)xmlSerializer.Deserialize(shapesFile);
        }
    }
}
