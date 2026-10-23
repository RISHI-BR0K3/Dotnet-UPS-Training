
using System;

public class RoundingTechniques
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a decimal number: ");
        double num = Convert.ToDouble(Console.ReadLine());

        double floor = Math.Floor(num);
        double ceiling = Math.Ceiling(num);
        double round = Math.Round(num);

        Console.WriteLine($"Original number = {num}");
        Console.WriteLine($"Floor = {floor}");
        Console.WriteLine($"Ceiling = {ceiling}");
        Console.WriteLine($"Round = {round}");
    }
}
