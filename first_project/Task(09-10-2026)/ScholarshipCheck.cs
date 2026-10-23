using System;

public class ScholarshipCheck
{
    public static void Main(String[] args)
    {
        Console.Write("Enter your grade: ");
        double grade = Convert.ToDouble(Console.ReadLine());

        double fees = 100000.00;
        Console.WriteLine("Fees: " + fees);

        if (grade >= 90)
        {
            fees = fees - (fees * 0.50);
            Console.WriteLine("Your fees after scholarship: " + fees);
        } 
        else
        {
            Console.WriteLine("You are not eligible for a scholarship.");
        }
        

    }
}