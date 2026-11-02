using System;

class StaticMethod
{

    static int a = 5;
    int b = 10;
    static void add(int a, int b)
    {
        Console.WriteLine(a+b);
    }

    static void sub(int a, int b)
    {
        Console.WriteLine(a-b);
    }

    public static void Main(string[] args)
    {
        add(a,b);
    }

}