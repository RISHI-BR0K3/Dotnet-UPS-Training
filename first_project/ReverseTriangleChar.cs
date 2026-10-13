using System;

public class ReverseTriangleChar
{
    public static void Main(String[] args)
    {
        Char alp = 'A';

        for (int i = 4; i >= 1; i--)
        {
            alp = 'A';
            for (int j = i; j >= 1; j--)
            {
                Console.Write(alp + " ");
                alp++;
            }
            Console.WriteLine();
        }
    }
}