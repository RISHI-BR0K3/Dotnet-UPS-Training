using System;

public class MultipleTables
{
    public static void Main(String[] args)
    {
        
        for(int i=1; i<=5; i++)
        {
            for(int j=1; j<=10; j++)
            {
                Console.WriteLine(i + " * " + j + " = " + i*j);
            }

            Console.WriteLine();
        }

    }
}