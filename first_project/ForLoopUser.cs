using System;

public class ForLoopUser
{
    public static void Main(String[] args)
    {
        
        Console.Write("Enter the start value: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the end value: ");
        int end = Convert.ToInt32(Console.ReadLine());

        if(start < end)
        {
            for(int i=start; i<=end; i++)
            {
                Console.Write(i + " ");
            }
        }
        else if(start > end)
        {
            for(int i=start; i>=end; i--)
            {
                Console.Write(i + " ");
            }
        }
        else
        {
            Console.WriteLine("No value should be same");
        }

    }
}