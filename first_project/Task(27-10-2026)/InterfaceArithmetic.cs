using System;

interface IA1
{
    void add(int a, int b);
    void sub(int a, int b);
}

interface IA2
{
    void mul(int a, int b);
    void div(int a, int b);
}

class Operation1 : IA1
{
    public void add(int a, int b)
    {
        Console.WriteLine($"{a} + {b} = {a+b}");
    }
    public void sub(int a, int b)
    {
        Console.WriteLine($"{a} - {b} = {a-b}");
    }
}

class Operation2 : IA2
{
    public void mul(int a, int b)
    {
        Console.WriteLine($"{a} x {b} = {a*b}");
    }
    public void div(int a, int b)
    {
        Console.WriteLine($"{a} / {b} = {a/b}");
    }
}



public class InterfaceExec
{
    static void Main(string[] args)
    {
        
        System.Console.WriteLine("Interface 1");
        Operation1 op1 = new Operation1();
        op1.add(2,5);
        op1.sub(5,2);
        
        System.Console.WriteLine();

        System.Console.WriteLine("Interface 2");
        Operation2 op2 = new Operation2();
        op2.mul(2,5);
        op2.div(10,2);

    }
}