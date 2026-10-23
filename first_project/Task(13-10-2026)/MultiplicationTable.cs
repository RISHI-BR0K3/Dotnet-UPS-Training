using System;

public class MultiplicationTable
{
    public static void Main(String[] args)
    {
        
        Console.Write("Enter a number to create multiplication table: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for(int i=1; i<=10; i++)
        {
            Console.WriteLine(number + " x " + i + " = " + (number*i));
        }

    }
}