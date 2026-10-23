using System;

public class Power
{
    public static void Main(String[] args)
    {
        System.Console.Write("Enter number: ");
        double n = Convert.ToDouble(Console.ReadLine());

        System.Console.Write("Enter exponent: ");
        double e = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine($"{n}^{e} = {Math.Pow(n,e)}");
    }
}