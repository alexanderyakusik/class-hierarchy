using System.Drawing;

namespace graphics_editor
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int EndX { get; set; }
        public int EndY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }
        public Color BorderColor { get; set; }
        public int BorderWidth { get; set; }

        public abstract void Draw(Graphics g, Pen pen);
        public abstract void RecalculateProperties();
    }
}
