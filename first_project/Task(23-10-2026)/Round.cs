using System;

public class Round
{
    public static void Main(String[] args)
    {
        
        System.Console.Write("Enter number: ");
        double n = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine($"The round of number {n} is {Math.Round(n)}");

    }
}