using System;

public class ArrayEvenCount
{
    public static void Main(String[] args)
    {
        
        int count = 0;
        int[] arr = new int[5];

        Console.WriteLine("Enter 5 numbers: ");

        for(int i=0; i<arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for(int i=0; i<arr.Length; i++)
        {
            if(arr[i] % 2 == 0)
            {
                count++;
            }
        }

        Console.WriteLine("The count of even numbers are: " + count);

    }
}