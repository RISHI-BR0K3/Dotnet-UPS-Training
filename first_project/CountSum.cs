using System;

public class CountSum
{
    public static void Main(String[] args)
    {
        
        int sum = 0;
        int count = 0;

        for(int i=5; i<=10; i++)
        {
            sum += i;
            count++;
        }

        Console.WriteLine(sum);
        Console.WriteLine(count);

    }
}