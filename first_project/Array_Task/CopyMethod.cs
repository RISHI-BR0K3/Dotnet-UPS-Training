using System;
using System.Diagnostics;

public class CopyMethod
{
    public static void Main(String[] args)
    {
        
        int[] arr = {1,2,3,4,5};
        
        int[] copy = new int[arr.Length];

        Array.Copy(arr, copy, arr.Length);

        foreach (int i in arr)
        {
            System.Console.Write(i + " ");
        }
        System.Console.WriteLine();
        
        foreach (int i in copy)
        {
            Console.Write(i + " ");
        }
        System.Console.WriteLine();
    }
}