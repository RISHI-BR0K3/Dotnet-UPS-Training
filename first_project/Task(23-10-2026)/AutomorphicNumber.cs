using System;

public class AutomorphicNumber
{
    public static void Main(String[] args)
    {
        
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int square = num * num;
        int temp = num;
        int digits = 0;

        while (temp > 0)
        {
            digits++;
            temp = temp / 10;
        }

        int divisor = (int)Math.Pow(10, digits);

        if (square % divisor == num)
        {
            Console.WriteLine("Automorphic Number");
        }
        else
        {
            Console.WriteLine("Not an Automorphic Number");
        }

    }
}