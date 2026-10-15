
using System;

public class MultipleArmstrongNumber
{
    public static void Main(string[] args)
    {
        for (int n = 100; n <= 2000; n++)
        {
            int temp = n;
            int lastDigit;
            int sum = 0;
            int nLength = n.ToString().Length;

            while (temp > 0)
            {
                lastDigit = temp % 10;
                sum += (int)Math.Pow(lastDigit, nLength);
                temp = temp / 10;
            }

            if (sum == n)
            {
                Console.WriteLine(n + " is an Armstrong number");
            }
        }
    }
}
