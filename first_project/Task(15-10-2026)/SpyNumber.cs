using System;

public class SpyNumber
{
    public static void Main(String[] args)
    {
        
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int prod = 1;

        while(n > 0)
        {
            int lastDigit = n % 10;
            sum += lastDigit;
            prod *= lastDigit;
            n = n/10;
        }

        if(sum == prod)
        {
            Console.WriteLine(sum + " and " + prod + " are spy numbers");
        }
        else
        {
            Console.WriteLine(sum + " and " + prod + " are not spy numbers");
        }

    }
}