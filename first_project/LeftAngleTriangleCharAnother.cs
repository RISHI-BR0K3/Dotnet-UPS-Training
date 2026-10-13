using System;

public class LeftAngleTriangleCharAnother
{
    public static void Main(String[] args)
    {
        Char alp = 'A';
        
        for(int i=4; i >= 1; i--)
        {

            alp = 'A';

            for(int k=1; k<=4-i; k++)
            {
                Console.Write("- ");
            }

            for(int j=1; j <= i; j++)
            {
                Console.Write(alp + " ");
                alp++;
                alp++;
            }

            Console.WriteLine();
        }
    }
}