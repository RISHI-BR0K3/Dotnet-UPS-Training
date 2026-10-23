using System;

public class MaxMin
{
    public static void Main(String[] args)
    {
        
        System.Console.Write("Enter number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Enter number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        //max
        System.Console.WriteLine($"The maximum of {a} and {b} is {Math.Max(a,b)}");

        //min
        System.Console.WriteLine($"The minimum of {a} and {b} is {Math.Min(a,b)}");

    }
}