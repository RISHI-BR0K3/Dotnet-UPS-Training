using System;

public class Absolute
{
    public static void Main(String[] args)
    {
        
        System.Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if(n < 0)
        {
            System.Console.WriteLine($"Absolute of {n} is {Math.Abs(n)}");
        }
        else
        {
            System.Console.WriteLine("Enter negative number to get absolute value");
        }

    }
}