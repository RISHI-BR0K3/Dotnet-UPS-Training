using System;

public class MultipleFactorial
{
    public static void Main(String[] args)
    {

        for(int i=1; i<=10; i++)
        {

            int fact = 1;
            
            for(int j=i; j>=1; j--)
            {
                fact *= j;
                
            }
            Console.Write(i + "! = " + fact);
            Console.WriteLine();
        }

    }
}