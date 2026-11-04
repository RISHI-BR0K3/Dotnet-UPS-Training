using System;
using System.Collections.Generic;
class DelegateAdd
{
    // define a method that returns sum of two int numbers 
    static int add(int x, int y)
    {
        return x + y;
    }
    static int sub(int x, int y)
    {
        return x - y;
    }
    static int mul(int x, int y)
    {
        return x * y;
    }

    // define a delegate
    public delegate int myDelegate(int num1, int num2);

    static void Main()
    {


        // create an instance of delegate by passing method name 
        myDelegate d = new myDelegate(add);
        int resultAdd = d(5, 6);

        d = sub;
        int resultSub = d(6,2); 

        d = mul;
        int resultMul = d(6,2); 

        Console.WriteLine(resultAdd);
        Console.WriteLine(resultSub);
        Console.WriteLine(resultMul);

    }
}
