
using System;

public class Trigonometry
{
    public static void Main(String[] args)
    {
        Console.Write("Enter angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        double radians = angle * Math.PI / 180;

        double sin = Math.Sin(radians);
        double cos = Math.Cos(radians);
        double tan = Math.Tan(radians);

        Console.WriteLine($"Sin = {sin}");
        Console.WriteLine($"Cos = {cos}");
        Console.WriteLine($"Tan = {tan}");
    }
}
