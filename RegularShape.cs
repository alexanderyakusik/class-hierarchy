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
                    SetWidthHeightAndCoords(parameters.minSide);
                }
                else
                {
                    X = parameters.minX;
                    Y = parameters.maxY - parameters.minSide;
                    SetWidthHeightAndCoords(parameters.minSide);
                }
            }
            else
            {
                if (X == parameters.minX)
                {
                    X = parameters.minX;
                    Y = parameters.minY;
                    SetWidthHeightAndCoords(parameters.minSide);
                }
                else
                {
                    X = parameters.maxX - parameters.minSide;
                    Y = parameters.minY;
                    SetWidthHeightAndCoords(parameters.minSide);
                }
            }
        }

        private void SetWidthHeightAndCoords(int minSide)
        {
            Width = Height = minSide;
            EndX = X + Width;
            EndY = Y + Height;
        }
    }
}
