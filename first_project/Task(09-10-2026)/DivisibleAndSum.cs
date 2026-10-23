using System;

public class DivisbleAndSum
{
    public static void Main(String[] args)
    {

        int sum = 0;

        for(int i=100; i<=150; i++)
        {
            if(i % 9 == 0)
            {
                Console.Write(i + " ");
                sum += i;
                Console.WriteLine();
            }
        }
        Console.WriteLine("Sum of numbers from 100 to 150 divisible by 9: " + sum);
    }
}