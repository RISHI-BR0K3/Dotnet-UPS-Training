using System;

public class Calculator
{

    static void add(double a, double b)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
    }

    static void sub(double a, double b)
    {
        Console.WriteLine($"{a} - {b} = {a - b}");
    }

    static void mul(double a, double b)
    {
        Console.WriteLine($"{a} x {b} = {a * b}");
    }

    static void div(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException();
        }
        Console.WriteLine($"{a} / {b} = {a / b}");
    }

    public static void Main(String[] args)
    {
        try
        {

            Console.Write("Enter number a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator to perform: ");
            char oper = Convert.ToChar(Console.ReadLine() ?? string.Empty);

            switch (oper)
            {
                case '+':
                    add(a, b);
                    break;

                case '-':
                    sub(a, b);
                    break;

                case '*':
                    mul(a, b);
                    break;

                case '/':
                    div(a, b);
                    break;

                default:
                    Console.WriteLine("Invalid operator!");
                    break;
            }
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("Number cannot divide by zero");
        }
        catch (FormatException)
        {
            Console.WriteLine("Enter a valid number or operator");
        }
        finally
        {
            Console.WriteLine("Memory Cleaned");
        }

    }
}