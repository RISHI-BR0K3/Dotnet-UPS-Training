
using System;

public class CompoundInterest
{
    public static void Main(String[] args)
    {
        Console.Write("Enter principal: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter rate: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time: ");
        int time = Convert.ToInt32(Console.ReadLine());

        double amount = principal * Math.Pow(1 + rate / 100, time);

        double compound_interest = amount - principal;

        Console.WriteLine($"Compound Interest = {compound_interest}");
    }
}
