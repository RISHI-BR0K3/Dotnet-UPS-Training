using System;

public class LeftAngleTriangleCharInverse
{
    public static void Main(String[] args)
    {

        Char alp = 'A';
        
        for(int i=4; i >= 1; i--)
        {

            for(int k=1; k<=4-i; k++)
            {
                Console.Write("- ");
            }

            for(int j=1; j <= i; j++)
            {
                Console.Write(alp + " ");
                alp++;
            }

            Console.WriteLine();
        }

    }
}