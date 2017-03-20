namespace graphics_editor
{
    public abstract class IrregularShape : Shape
    {
        public override void RecalculateProperties()
        {
            var shapeParameters = new ShapeParameters(this);

            X = shapeParameters.minX;
            EndX = shapeParameters.maxX;
            Y = shapeParameters.minY;
            EndY = shapeParameters.maxY;

            Width = shapeParameters.deltaX;
            Height = shapeParameters.deltaY;
        }
    }
}
