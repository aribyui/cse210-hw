using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Square square = new Square("Red", 2);
        // // Console.WriteLine(square.GetColor());
        // // Console.WriteLine(square.GetArea());

        // Rectangle rectangle = new Rectangle("Yellow", 2, 8);
        // // Console.WriteLine(rectangle.GetColor());
        // // Console.WriteLine(rectangle.GetArea());

        // Circle circle = new Circle("Blue", 15);
        // // Console.WriteLine(circle.GetColor());
        // // Console.WriteLine(circle.GetArea());

        // Console.WriteLine();

        // List<Shape> shapes = new List<Shape>();
        // shapes.Add(square);
        // shapes.Add(rectangle);
        // shapes.Add(circle);

        Console.WriteLine();

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Red", 2));
        shapes.Add(new Rectangle("Yellow", 2, 8));
        shapes.Add(new Circle("Blue", 15));

        foreach (Shape s in shapes)
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
        }

        Console.WriteLine();
    }
}