using System;

public abstract class Shape
{
    public abstract double GetArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;  // Area of a circle: πr²
    }
}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double GetArea()
    {
        return Length * Width;  // Area of a rectangle: length × width
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape myCircle = new Circle(5);  // Create a Circle with radius 5
        Console.WriteLine("Area of Circle: " + myCircle.GetArea());

        Shape myRectangle = new Rectangle(4, 6);  // Create a Rectangle with length 4 and width 6
        Console.WriteLine("Area of Rectangle: " + myRectangle.GetArea());
    }
}
