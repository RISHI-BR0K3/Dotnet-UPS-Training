using System;

abstract class Arithmetic
{
    public abstract void Operation(int a, int b);

    public void info()
    {
        Console.WriteLine("This is an Arithmetic Operations");
    }
}

class Add : Arithmetic
{
    public override void Operation(int a, int b)
    {
        Console.WriteLine($"{a} + {b} = {a+b}");
    }
}

class Sub : Arithmetic
{
    public override void Operation(int a, int b)
    {
        Console.WriteLine($"{a} - {b} = {a-b}");
    }
}

class Mul
{
    public void Operation(int a, int b)
    {
        Console.WriteLine($"{a} x {b} = {a*b}");
    }
}

class Div
{
    public void Operation(int a, int b)
    {
        Console.WriteLine($"{a} / {b} = {a/b}");
    }
}

public class ExecArithmetic
{
    public static void Main(String[] args)
    {
        
        Add a = new Add();
        Sub s = new Sub();
        Mul m = new Mul();
        Div d = new Div();

        a.Operation(5,2);
        s.Operation(5,2);
        m.Operation(5,2);
        d.Operation(5,2);

    }
}