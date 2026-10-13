
using System;

public class OddReverseTriangle
{
    public static void Main(String[] args)
    {
        for (int i = 5; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write((j*2-1) + " ");
            }
            Console.WriteLine();
        }
    }
}
