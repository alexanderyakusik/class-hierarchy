using System.Drawing;

namespace class_hierarchy
{
    public abstract class Shape
    {
        public int X { get; }
        public int Y { get; }

        public Shape (int x, int y)
        {
            X = x;
            Y = y;
        }

        public abstract void Draw(Graphics g, Pen pen); 
    }
}
