using System;

public class HarshadNumber
{
    public static void Main(String[] args)
    {
        
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int lastDigit;
        int sum = 0;
        int original = n;

        while (n > 0)
        {
            lastDigit = n % 10;
            sum += lastDigit;
            n = n / 10;
        }

        if(original % sum == 0)
        {
            Console.WriteLine(original + " % " + sum + " = 0 " );
            Console.WriteLine("It is Harshad Number");
        }
        else
        {
            Console.WriteLine("The given number is not Harshad Number");
        }

    }
}