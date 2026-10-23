
using System;

public class ExponentialGrowth
{
    public static void Main(String[] args)
    {
        Console.Write("Enter initial population: ");
        double initial = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter growth rate (decimal): ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter number of years: ");
        int years = Convert.ToInt32(Console.ReadLine());

        double population = initial * Math.Exp(rate * years);

        Console.WriteLine($"Population after {years} years = {Math.Round(population, 2)}");
    }
}
