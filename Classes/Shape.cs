using System.Drawing;

namespace graphics_editor
{
    public abstract class Shape : ISelectable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int EndX { get; set; }
        public int EndY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }

        public abstract void Draw(Graphics g, Pen pen);
        public abstract void RecalculateProperties();

        public void Select(Graphics g, Pen pen)
        {
            g.DrawRectangle(pen, X, Y, Width, Height);
        }
    }
}
