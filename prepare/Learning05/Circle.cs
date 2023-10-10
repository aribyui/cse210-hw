public class Circle : Shape
{
    private double _radius = 0;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    public double GetRadius()
    {
        return _radius;
    }
    public void SetRadius(double radius)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        // double area = Math.PI * Math.Pow(_radius, 2);
        // return Math.Round(area, 2);

        return Math.Round(Math.PI * Math.Pow(_radius, 2), 2);
    }
}