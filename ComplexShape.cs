namespace graphic_editor
{
    public class ComplexShape : Dot
    {
        public int width { get; set; }
        public int height { get; set; }
        protected int init_x;
        protected int init_y;

        public ComplexShape(int x, int y, int width, int height) : base(x, y)
        {
            this.width = width;
            this.height = height;
        }

        protected virtual void RecalculateCoords()
        {
            if (end_x < x)
            {
                init_x = end_x;
                width = x - end_x;
            }
            else
            {
                init_x = x;
                width = end_x - x;
            }

            if (end_y < y)
            {
                init_y = end_y;
                height = y - end_y;
            }
            else
            {
                init_y = y;
                height = end_y - y;
            }
        }
    }
}
