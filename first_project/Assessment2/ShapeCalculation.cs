
using System;

abstract class Shape
{
    public abstract double Area { get; protected set; }

    public abstract void CalculateArea();

    public void DisplayArea()
    {
        Console.WriteLine($"Area: {Area}");
    }
}

class Circle : Shape
{
    double radius;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be positive.");

        this.radius = radius;
    }

    public override double Area { get; protected set; }

    public override void CalculateArea()
    {
        Area = 3.14 * radius * radius;
    }

    public void Display()
    {
        Console.WriteLine("\nShape: Circle");
        Console.WriteLine($"Radius: {radius}");
        DisplayArea();
    }
}

class Rectangle : Shape
{
    double length, width;

    public Rectangle(double length, double width)
    {
        if (length <= 0 || width <= 0)
            throw new ArgumentException("Dimensions must be positive.");

        this.length = length;
        this.width = width;
    }

    public override double Area { get; protected set; }

    public override void CalculateArea()
    {
        Area = length * width;
    }

    public void Display()
    {
        Console.WriteLine("\nShape: Rectangle");
        Console.WriteLine($"Length: {length}");
        Console.WriteLine($"Width: {width}");
        DisplayArea();
    }
}

class Triangle : Shape
{
    double baseValue, height;

    public Triangle(double baseValue, double height)
    {
        if (baseValue <= 0 || height <= 0)
            throw new ArgumentException("Dimensions must be positive.");

        this.baseValue = baseValue;
        this.height = height;
    }

    public override double Area { get; protected set; }

    public override void CalculateArea()
    {
        Area = 0.5 * baseValue * height;
    }

    public void Display()
    {
        Console.WriteLine("\nShape: Triangle");
        Console.WriteLine($"Base: {baseValue}");
        Console.WriteLine($"Height: {height}");
        DisplayArea();
    }
}

class ShapeCalculation
{
    static void Main()
    {
        try
        {
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Triangle");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());

                    Circle c = new Circle(radius);
                    c.CalculateArea();
                    c.Display();
                    break;

                case 2:
                    Console.Write("Enter length: ");
                    double length = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter width: ");
                    double width = Convert.ToDouble(Console.ReadLine());

                    Rectangle r = new Rectangle(length, width);
                    r.CalculateArea();
                    r.Display();
                    break;

                case 3:
                    Console.Write("Enter base: ");
                    double baseValue = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter height: ");
                    double height = Convert.ToDouble(Console.ReadLine());

                    Triangle t = new Triangle(baseValue, height);
                    t.CalculateArea();
                    t.Display();
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid input! Enter positive numbers.");
        }
    }
}
