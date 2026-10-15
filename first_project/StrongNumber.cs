
using System;

public class StrongNumber
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int temp = n;
        int lastDigit;
        int sum = 0;

        while (n > 0)
        {
            lastDigit = n % 10;
            int fact = 1;

            for (int i = lastDigit; i > 0; i--)
            {
                fact *= i;
            }

            sum += fact;
            n = n / 10;
        }

        if (sum == temp)
        {
            Console.WriteLine(temp + " is a Strong Number");
        }
        else
        {
            Console.WriteLine(temp + " is not a Strong Number");
        }
    }
}
