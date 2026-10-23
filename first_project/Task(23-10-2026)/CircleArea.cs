
using System;

public class CircleArea
{
    public static void Main(String[] args)
    {
        Random random = new Random();

        double radius = random.Next(1, 11);

        double area = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine($"Random radius = {radius}");
        Console.WriteLine($"Area of circle = {Math.Round(area, 2)}");
    }
}
