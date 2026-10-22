using System;

public class KthLargestSmallest
{
    public static void Main(String[] args)
    {
        
        int[] arr = { 678, 23, 901, 145, 389, 72, 510, 264 };
        int n = arr.Length;
        Array.Sort(arr);

        System.Console.Write("Enter the K to find the Kth largest and Kth smallest: ");
        int K = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("The " + K + " smallest number in array is: " + arr[K - 1]);

        System.Console.WriteLine("The " + K + " largest number in array is: " + arr[n - K]);

    }
}