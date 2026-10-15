using System;

public class CheckSumOfDivisor
{
    public static void Main(String[] args)
    {
        
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for(int i=1; i<n; i++)
        {
            if(n % i == 0)
            {
                sum += i;
            }
        }

        if(n == sum)
        {
            Console.WriteLine("Perfect Number: " + sum);
        } 
        else if (sum > n)
        {
            Console.WriteLine("Abundant Number");
        }
        else
        {
            Console.WriteLine("Deficient Number");
        }

    }
}