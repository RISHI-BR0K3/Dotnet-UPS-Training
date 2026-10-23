using System;

public class ArmstrongNumber
{
    public static void Main(String[] args)
    {
        
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        int temp = n;
        int lastDigit = 0;
        int sum = 0;
        int nLength = n.ToString().Length;

        while(n > 0)
        {
            lastDigit = n % 10;
            sum += (int)Math.Pow(lastDigit,nLength);
            n = n/10;
        }

        if(sum == temp)
        {
            Console.WriteLine(sum + " is a Armstrong number");
        }
        else
        {
            Console.WriteLine(temp + " is not a Armstrong Number");
        }

    }
}