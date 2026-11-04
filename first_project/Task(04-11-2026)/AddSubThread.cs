using System;
using System.Threading;

class Operation
{
    public void add()
    {
        Console.WriteLine("Addition Started");
        Thread.Sleep(2000);
        Console.WriteLine("Addition Ended");
    }

    public void subtract()
    {
        Console.WriteLine("Subtraction Started");
        Thread.Sleep(1000);
        Console.WriteLine("Subtraction Ended");
    }

    public static void mul(int a, int b)
    {
        Console.WriteLine($"Multiplication started = {a*b}");
        Thread.Sleep(4000);
        Console.WriteLine($"Multiplicated ended");
    }

    public static void div(int a, int b)
    {
        Console.WriteLine($"Division started = {a/b}");
        Thread.Sleep(3000);
        Console.WriteLine($"Divison ended");
    }
}

class ExecOperation
{
    public static void Main(string[] args)
    {
        
        Operation op = new Operation();
        Thread t1 = new Thread(op.add);
        Thread t2 = new Thread(op.subtract);

        //static method
        Thread t3 = new Thread(() => Operation.mul(2,5));
        Thread t4 = new Thread(() => Operation.div(10,5));

        t1.Start();
        t2.Start();
        t3.Start();
        t4.Start();

    }
}