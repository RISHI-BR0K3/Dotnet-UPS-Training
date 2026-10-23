
using System;

public class Logarithm
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a positive number: ");
        double num = Convert.ToDouble(Console.ReadLine());

        if (num > 0)
        {
            double log10 = Math.Log10(num);
            double loge = Math.Log(num);

            Console.WriteLine($"Log base 10 = {log10}");
            Console.WriteLine($"Natural log = {loge}");
        }
        else
        {
            Console.WriteLine("Enter a positive number.");
        }
    }
}
