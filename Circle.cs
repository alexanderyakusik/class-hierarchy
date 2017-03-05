namespace class_hierarchy
{
    public class Circle : Ellipse
    {
        public Circle(int x, int y, int radius) : base (x - radius, y - radius, radius * 2, radius * 2) { }
    }
}
