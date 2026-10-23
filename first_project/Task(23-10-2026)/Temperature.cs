using System;

public class Temperature
{
    public static void Main(String[] args)
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (celsius * 9.0 / 5) + 32;
        fahrenheit = Math.Round(fahrenheit, 2);

        Console.WriteLine($"Temperature in Fahrenheit = {fahrenheit}");
    }
}
