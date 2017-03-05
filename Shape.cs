using System.Drawing;

namespace class_hierarchy
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int EndX { get; set; }
        public int EndY { get; set; }

        public abstract void Draw(Graphics g, Pen pen); 
    }
}
