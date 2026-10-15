
using System;

public class NeonNumber
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int nSquared = n * n;
        int original = n;

        while (nSquared > 0)
        {
            int lastDigit = nSquared % 10;
            sum += lastDigit;
            nSquared = nSquared / 10;
        }

        if (sum == original)
        {
            Console.WriteLine("It is a Neon Number");
        }
        else
        {
            Console.WriteLine("It is not a Neon Number");
        }
    }
}
