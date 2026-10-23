using System;

public class SquarePattern
{
    public static void Main(String[] args)
    {
        
        //4x4
        for(int i=1; i<=4; i++)
        {
            for(int j=1; j<=4; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

    }
}