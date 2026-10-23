using System;

public class LeftAngleTriangleChar
{
    public static void Main(String[] args)
    {

        Char alp = 'A';
        
        for(int i=1; i <= 4; i++)
        {
            for(int j = 1; j <= 4-i; j++)
            {
                Console.Write("- ");
            }

            for(int k=1; k <= i; k++)
            {
                Console.Write(alp + " ");
                alp++;
            }

            Console.WriteLine();
        }

    }
}