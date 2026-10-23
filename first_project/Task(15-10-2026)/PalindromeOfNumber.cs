using System;
using System.Diagnostics;

public class PalindromeOfNumber
{
    public static void Main(String[] args)
    {
        
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int lastDigit;
        int sum = 0;
        int original = n;

        while(n > 0)
        {
            lastDigit = (n % 10);
            sum = (sum*10) + lastDigit;
            n = n / 10;
        }

        if(sum == original)
        {
            Console.WriteLine(original + " is Palindrome");
        }
        else
        {
            Console.WriteLine(original + " is not Palindrome");
        }

    }
}