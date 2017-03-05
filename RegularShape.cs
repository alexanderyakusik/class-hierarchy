namespace graphics_editor
{
    public abstract class RegularShape : Shape
    {
        public override void RecalculateProperties()
        {
            var parameters = new ShapeParameters(this);

            if (parameters.deltaX < parameters.deltaY)
            {
                if (Y == parameters.minY)
                {
                    X = parameters.minX;
                    Y = parameters.minY;
                    Width = Height = parameters.deltaX;
                    EndX = X + Width;
                    EndY = Y + Height;
                }
                else
                {
                    X = parameters.minX;
                    Y = parameters.maxY - parameters.deltaX;
                    Width = Height = parameters.deltaX;
                    EndX = X + Width;
                    EndY = Y + Height;
                }
            }
            else
            {
                if (X == parameters.minX)
                {
                    X = parameters.minX;
                    Y = parameters.minY;
                    Width = Height = parameters.deltaY;
                    EndX = X + Width;
                    EndY = Y + Height;
                }
                else
                {
                    X = parameters.maxX - parameters.deltaY;
                    Y = parameters.minY;
                    Width = Height = parameters.deltaY;
                    EndX = X + Width;
                    EndY = Y + Height;
                }
            }
        }
    }
}
