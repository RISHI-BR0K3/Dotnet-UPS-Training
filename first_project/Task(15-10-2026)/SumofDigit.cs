using System;

public class SumofDigit
{
    public static void Main(String[] args)
    {
        
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());


        int temp = n;
        int lastDigit = 0;
        // int div = 0;
        int sum = 0;

        while (n > 0)
        {
            lastDigit = n % 10;
            n = n / 10;
            sum += lastDigit;
        }

        Console.WriteLine("Sum of Digit (" + temp + ") = " + sum);


    }
}