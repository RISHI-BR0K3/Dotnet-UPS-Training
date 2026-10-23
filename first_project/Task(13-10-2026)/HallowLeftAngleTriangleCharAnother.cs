
using System;

public class HallowLeftAngleTriangleCharAnother
{
    public static void Main(String[] args)
    {
        for (int i = 4; i >= 1; i--)
        {
            char alp = 'A';

            for (int k = 1; k <= 2 * (4 - i); k++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                if (i == 4 || j == 1 || j == i)
                {
                    Console.Write(alp + " ");
                }
                else
                {
                    Console.Write("  ");
                }

                alp++;
                alp++;
            }

            Console.WriteLine();
        }
    }
}
