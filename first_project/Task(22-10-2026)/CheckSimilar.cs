using System;

public class CheckSimilar
{
    public static void Main(String[] args)
    {
        
        int[] arr = { 678, 23, 901, 145, 389, 72, 510, 264 };
        
        int[] copy_arr = new int[arr.Length];

        Array.Copy(arr, copy_arr, arr.Length);

        bool isSimilar = true;

        for(int i=0; i<arr.Length; i++)
        {
            if(arr[i] != copy_arr[i])
            {
                isSimilar = false;
                break;
            }
        }

        if (isSimilar)
        {
            System.Console.WriteLine("The array is similar");
        }
        else
        {
            System.Console.WriteLine("No the array is not similar");
        }

    }
}