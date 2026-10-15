using System;

public class PrimeNumber
{
    public static void Main(String[] args)
    {
        
        Console.Write("Enter a value to check Prime: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Boolean isPrime = true;

        for(int i=2; i<n; i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            Console.WriteLine("Prime");
        }
        else
        {
            Console.WriteLine("Composite Number");
        }

    }
}