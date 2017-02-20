using System.Drawing;

namespace class_hierarchy
{
    public abstract class Shape
    {
        public int x { get; set; }
        public int y { get; set; }

        public Shape (int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Shape Clone()
        {
            return (Shape)MemberwiseClone();
        }

        public abstract void Draw(Graphics g, Brush brush); 
    }
}
