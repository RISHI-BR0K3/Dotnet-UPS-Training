
using System;

public class Quadratic
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double d = Math.Pow(b, 2) - 4 * a * c;

        if (a == 0)
        {
            Console.WriteLine("Not a quadratic equation.");
        }
        else if (d > 0)
        {
            double root1 = (-b + Math.Sqrt(d)) / (2 * a);
            double root2 = (-b - Math.Sqrt(d)) / (2 * a);

            Console.WriteLine($"Root 1 = {root1}");
            Console.WriteLine($"Root 2 = {root2}");
        }
        else if (d == 0)
        {
            double root = -b / (2 * a);

            Console.WriteLine($"Both roots = {root}");
        }
        else
        {
            double real = -b / (2 * a);
            double imaginary = Math.Sqrt(-d) / Math.Abs(2 * a);

            Console.WriteLine($"Root 1 = {real} + {imaginary}i");
            Console.WriteLine($"Root 2 = {real} - {imaginary}i");
        }
    }
}
