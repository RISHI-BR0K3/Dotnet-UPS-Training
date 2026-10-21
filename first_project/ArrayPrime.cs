using System;

public class ArrayPrime
{
    public static void Main(String[] args)
    {
        int size = 5;
        int[] arr = new int[size];

        for (int z = 0; z < arr.Length; z++)
        {
            arr[z] = Convert.ToInt32(Console.ReadLine());
        }

        for (int z = 0; z < arr.Length; z++)
        {
            int count = 0;
            int n = arr[z];

            if (n <= 1)
            {
                Console.WriteLine("Neither prime nor composite");
                continue;
            }

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                Console.WriteLine(n + " is a composite number");
            }
            else
            {
                Console.WriteLine(n + " is a prime number");
            }
        }
    }
}