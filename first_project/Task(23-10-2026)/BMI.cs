using System;

public class BMI
{
    public static void Main(String[] args)
    {
        
        Console.Write("Enter Weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double BMI = weight / (Math.Pow(height,2));

        System.Console.WriteLine($"Body Mass Index = {BMI}");

    }
}