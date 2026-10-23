using System;

public class RectanglePattern
{
    public static void Main(String[] args)
    {
        
        //4x4
        for(int i=1; i<=4; i++)
        {
            for(int j=1; j<=6; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

    }
}