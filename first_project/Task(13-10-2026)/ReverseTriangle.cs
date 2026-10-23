
using System;

public class ReverseTriangle
{
    public static void Main(String[] args)
    {
        for (int i = 4; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
