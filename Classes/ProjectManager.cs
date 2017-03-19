using System;
using System.IO;
using System.Xml.Serialization;

namespace graphics_editor
{
    public static class ProjectManager
    {
        public static void SaveShapes(FileStream file)
        {
            foreach (Shape shape in ShapesList.Shapes)
            {
                var xmlSerializer = new XmlSerializer(shape.GetType());
                xmlSerializer.Serialize(file, shape);
            }
        }

        public static void LoadShapes(FileStream file)
        {
            throw new NotImplementedException();
        }
    }
}
