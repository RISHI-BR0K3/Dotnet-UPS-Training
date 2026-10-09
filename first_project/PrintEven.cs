using System;

public class PrintEven
{
    public static void Main(String[] args)
    {
        for(int i=1; i<=10; i++)
        {
            if(i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}