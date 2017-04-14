namespace graphics_editor
{
    public abstract class IrregularShape : Shape
    {
        public override void RecalculateProperties()
        {
            ShapeParameters parameters = CalculateShapeParams();

            X = parameters.minX;
            EndX = parameters.maxX;
            Y = parameters.minY;
            EndY = parameters.maxY;

            Width = parameters.deltaX;
            Height = parameters.deltaY;
        }
    }
}
