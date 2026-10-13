using System;

public class WeirdSquarePattern
{
    public static void Main(String[] args)
    {
        
        for(int i=1; i<=5; i++)
        {
            for(int j=1; j<=5; j++)
            {
                if (j <= i)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(j);
                }
            }
            Console.WriteLine();
        }

    }
}