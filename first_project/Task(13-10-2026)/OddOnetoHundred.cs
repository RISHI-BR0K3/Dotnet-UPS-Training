using System;

public class OddOnetoHundred
{
    public static void Main(String[] args)
    {
        for(int i=1; i<=100; i++)
        {
            if(i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}