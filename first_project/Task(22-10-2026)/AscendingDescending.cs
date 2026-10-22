using System;

public class AscendingDescending
{
    public static void Main(String[] args)
    {
        
        int[] arr = {50, 35, 10, 45, 20, 199, 82};

        System.Console.Write("Original Array: ");
        foreach (int i in arr)
        {
            System.Console.Write(i + " ");
        }
        System.Console.WriteLine();

        Array.Sort(arr);
        System.Console.Write("Ascending Order: ");
        foreach (int i in arr)
        {
            System.Console.Write(i + " ");
        }
        System.Console.WriteLine();

        Array.Reverse(arr);
        System.Console.Write("Descending Order: ");
        foreach (int i in arr)
        {
            System.Console.Write(i + " ");
        }
        System.Console.WriteLine();

    }
}