using System;

public class CalcySwitch
{
    public static void Main(String[] args)
    {
        
        Console.Write("Enter the value for a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value for b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the operation you want to perform (+ - * / % ): ");
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (ch)
        {
            case '+':
                Console.WriteLine(a+b);
                break;

            case '-':
                Console.WriteLine(a-b);
                break;

            case '*':
                Console.WriteLine(a*b);
                break;

            case '/':
                Console.WriteLine(a/b);
                break;

            case '%':
                Console.WriteLine(a%b);
                break;

            default:
                Console.WriteLine("Enter the correct operator to perform the operation");
                break;
        }
        
    }
}