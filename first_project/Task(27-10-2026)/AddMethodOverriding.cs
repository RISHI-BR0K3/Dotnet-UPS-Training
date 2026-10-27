using System;

class AddMethod
{

    public void Add(int a, int b)
    {
        System.Console.WriteLine($"The sum of {a} and {b} is {a+b}");
    }

    public void Add(double a, double b)
    {
        System.Console.WriteLine($"The sum of {a} and {b} is {a+b}");
    }

    public void Add(String a, String b, String c)
    {
        System.Console.WriteLine(a + " " + b + " " + c);
    }

}

class ProgramExec
{
    public static void Main(String[] args)
    {
        
        AddMethod addMethod = new AddMethod();

        //int
        addMethod.Add(10,5);

        //double
        addMethod.Add(7.33, 2.77);

        //string
        addMethod.Add("spongebob", "square", "pants");
        

    }
}