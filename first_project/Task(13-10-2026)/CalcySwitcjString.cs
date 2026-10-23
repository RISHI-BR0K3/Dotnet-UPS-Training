using System;

public class CalcyString
{
    public static void Main(String[] args)
    {
        
        Console.Write("Enter the value for a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value for b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the operation you want to perform (add, sub, mul, div, mod): ");
        String operation = Console.ReadLine();
        
        switch (operation)
        {
            case "add":
                Console.WriteLine(a+b);
                break;

            case "sub":
                Console.WriteLine(a-b);
                break;

            case "mul":
                Console.WriteLine(a*b);
                break;

            case "div":
                Console.WriteLine(a/b);
                break;

            case "mod":
                Console.WriteLine(a%b);
                break;

            default:
                Console.WriteLine("Enter the correct operator to perform the operation");
                break;
        }
        
    }
}