using System;

public class TwistedPrime
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int original = n;
        int reverse = 0;

        while (n > 0)
        {
            int lastDigit = n % 10;
            reverse = reverse * 10 + lastDigit;
            n = n / 10;
        }

        bool isPrime = true;

        if (original <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i < original; i++)
            {
                if (original % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        bool reverseIsPrime = true;

        if (reverse <= 1)
        {
            reverseIsPrime = false;
        }
        else
        {
            for (int i = 2; i < reverse; i++)
            {
                if (reverse % i == 0)
                {
                    reverseIsPrime = false;
                    break;
                }
            }
        }

        if (isPrime && reverseIsPrime)
        {
            Console.WriteLine(original + " and " + reverse + " are Twisted Primes");
        }
        else
        {
            Console.WriteLine("Not a Twisted Prime");
        }
    }
}
