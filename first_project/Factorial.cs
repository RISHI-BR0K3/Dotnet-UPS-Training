using System;

public class Factorial
{
    public static void Main(String[] args)
    {
        
        int fact = 1;

        Console.Write("Enter a number to find the factorial: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for(int i=number; i>=1; i--)
        {
            fact *= i;
        }

        Console.WriteLine(fact);

    }
}