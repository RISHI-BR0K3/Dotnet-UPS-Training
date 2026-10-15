using System;

public class MultiplePrime
{
    public static void Main(String[] args)
    {

        for(int i=1; i<=100; i++)
        {

            Boolean isPrime = true;

            for(int j=2; j<i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.Write( i + " " );
            }
        }
        Console.WriteLine();
    }
}