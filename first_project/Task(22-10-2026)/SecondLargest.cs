using System;

public class SecondLargest
{
    public static void Main(String[] args)
    {
        
        int[] arr = {30, 45, 10, 50, 20};

        System.Console.Write("Given array is: ");
        foreach (int a in arr)
        {
            System.Console.Write(a + " ");
        }
        System.Console.WriteLine();

        Array.Sort(arr);

        System.Console.Write("Sorted Array is: ");
        foreach (int i in arr)
        {
            System.Console.Write(i + " ");
        }
        System.Console.WriteLine();

        System.Console.WriteLine("The second largest element in array is: " + arr[arr.Length - 2]);

    }
}