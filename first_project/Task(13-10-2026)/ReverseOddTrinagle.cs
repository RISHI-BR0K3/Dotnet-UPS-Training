using System;

public class ReverseOddTriangle
{
    public static void Main(String[] args)
    {
        for (int i = 9; i >= 1; i -= 2)
        {
            for (int j = 9; j >=i; j -= 2)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}