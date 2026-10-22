using System;

public class ReveseElement
{
    public static void Main(String[] args)
    {
        
        int[] arr = {1, 3, 5, 7, 9};

        for(int i=(arr.Length - 1); i >= 0; i--)
        {
            System.Console.Write(arr[i] + " ");
        }
        System.Console.WriteLine();
    }
}