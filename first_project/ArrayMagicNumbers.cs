
using System;

class ArrayMagicNumbers
{
    static void Main(String[] args)
    {
        int[] arr = new int[5];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length; i++)
        {
            int n = arr[i];
            int sum = n;

            while (sum > 9)
            {
                int temp = sum;
                sum = 0;

                while (temp > 0)
                {
                    sum += temp % 10;
                    temp /= 10;
                }
            }

            if (sum == 1)
            {
                Console.WriteLine(n + " is a Magic Number");
            }
            else
            {
                Console.WriteLine(n + " is not a Magic Number");
            }
        }
    }
}
