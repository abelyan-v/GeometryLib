namespace GeometryLib
{
    public class AreaCalculator
    {
        public double CalculateArea(IShape shape)
        {
            return shape.GetArea();
        }
    }
}
