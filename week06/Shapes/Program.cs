using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.\n");

        // Square class
        Square square = new Square("blue", 3);
        // Console.WriteLine($"The square is {square.GetColor()} and its area is {square.GetArea()}\n");

        // Rectangle Class
        Rectangle rectangle = new Rectangle("Red", 10, 2);
        // Console.WriteLine($"The rectangle is {rectangle.GetColor()} and its area is {rectangle.GetArea()}\n");

        // Circle class
        Circle circle = new Circle("Green", 4);
        // Console.WriteLine($"The circle is {circle.GetColor()} and its area is {circle.GetArea()}\n");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape s in shapes)
        {
            Console.WriteLine($"The {s.ToString()} class is {s.GetColor()} and its area is {s.GetArea()}\n");
        }
    }
}