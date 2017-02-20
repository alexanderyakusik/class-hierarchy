namespace graphic_editor
{
    public class Square : Rectangle 
    {
        public Square(int x, int y, int sideLength) : base(x, y, sideLength, sideLength) { }

        protected override void RecalculateCoords()
        {
            base.RecalculateCoords();
            if (width > height)
            {
                width = height;
                if (end_x == init_x)
                    end_x = init_x = x - width;
                else
                    end_x = width + x;
            }
            else
            {
                height = width;
                if (end_y == init_y)
                    end_y = init_y = y - height;
                else
                    end_y = height + y;
            }
        }
    }
}
