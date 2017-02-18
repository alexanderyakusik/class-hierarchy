using System.Drawing;

namespace class_hierarchy
{
    public abstract class Shape
    {
        public int x { get; }
        public int y { get; }

        public Shape (int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract void Draw(Graphics g, Brush brush); 
    }
}
