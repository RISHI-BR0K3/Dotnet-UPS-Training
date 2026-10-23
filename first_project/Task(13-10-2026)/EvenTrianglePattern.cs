using System;

public class EvenTrianglePattern
{
    public static void Main(String[] args)
    {
        
        for(int i=1; i<=4; i++)
        {
            for(int j=1; j<=i; j++)
            {
                
                Console.Write(j*2 + " ");

            }
            Console.WriteLine();
        }

    }
}