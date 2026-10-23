using System;

public class Distance
{
    public static void Main(String[] args)
    {
        
        Console.Write("Enter x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        double distance = Math.Sqrt( Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) );

        System.Console.WriteLine($"Distance = {distance}");

    }
}