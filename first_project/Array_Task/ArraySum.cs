using System;

public class ArraySum
{
    public static void Main(String[] args)
    {
        
        int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        int sum = 0;

        for(int i=0; i<arr.Length; i++)
        {
            sum += arr[i];
        }

        System.Console.WriteLine("The sum of array us: " + sum);

    }
}