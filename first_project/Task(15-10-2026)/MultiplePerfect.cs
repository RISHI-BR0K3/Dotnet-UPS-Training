using System;
using System.Diagnostics.CodeAnalysis;

public class MultiplePerfect
{
    public static void Main(String[] args)
    {
        
        for(int a=1; a<=100; a++)
        {
            int sum = 0;

            for(int i=1; i<a; i++)
            {
                if(a % i == 0)
                {
                    sum += i;
                }
            }

            if(a == sum)
            {
                Console.WriteLine("Perfect Number: " + sum);
            } 
        }

    }
}