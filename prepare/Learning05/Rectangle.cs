public class Rectangle : Shape
{
    private double _lenght = 0;
    private double _width = 0;

    public Rectangle(string color, double length, double width) : base(color)
    {
        _lenght = length;
        _width = width;
    }
    public double GetLength()
    {
        return _lenght;
    }
    public void SetLength(double length)
    {
        _lenght = length;
    }
    public double GetWidth()
    {
        return _width;
    }
    public void SetWidth(double width)
    {
        _width = width;
    }
    public override double GetArea()
    {
        return _lenght * _width;
    }
}