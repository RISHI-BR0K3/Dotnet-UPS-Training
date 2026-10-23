using System;

public class CountOfDigits
{
    public static void Main(String[] args)
    {
        
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int count = 0;

        while(n > 0)
        {
            int lastDigit = n % 10;
            n = n/10;
            count++;
        }

        Console.WriteLine("Count: " + count);

    }
}