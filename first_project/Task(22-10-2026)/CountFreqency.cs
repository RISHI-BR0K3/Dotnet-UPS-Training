using System;

public class CountFrequency
{
    public static void Main(String[] args)
    {
        
        int[] arr = { 11, 91, 31, 11, 51, 21, 71, 51 };
        int n = arr.Length;

        for(int i = 0; i < n; i++)
        {
            int count = 0;

            bool isVisited = false;

            for(int j=0; j<i; j++)
            {
                if (arr[i] == arr[j])
                {
                    isVisited = true;
                    break;
                }
            }

            if (isVisited)
            {
                continue;
            }

            for(int j = 0; j < n; j++)
            {
                if(arr[i] == arr[j])
                {
                    count++;
                }
            }

            Console.WriteLine(arr[i] + " occurs " + count + " times");
        }

    }
}