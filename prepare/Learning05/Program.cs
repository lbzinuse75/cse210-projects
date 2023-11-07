using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("red", 5);
        string squareColor = square.GetColor();
        double squareArea = square.GetArea();
        shapes.Add(square);
        
        Console.WriteLine($"Color: {squareColor}");
        Console.WriteLine($"Area: {squareArea}");

        Rectangle rectangle = new Rectangle("yellow", 5, 10);
        string rectangleColor = rectangle.GetColor();
        double rectangleArea = rectangle.GetArea();
        shapes.Add(rectangle);

        Console.WriteLine($"Color: {rectangleColor}");
        Console.WriteLine($"Area: {rectangleArea}");

        Circle circle = new Circle("orange", 5);
        string circleColor = circle.GetColor();
        double circleArea = circle.GetArea();
        shapes.Add(circle);

        Console.WriteLine($"Color: {circleColor}");
        Console.WriteLine($"Area: {circleArea}");

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"Shape: {color} has an area of {area}.");
        }
    }
}