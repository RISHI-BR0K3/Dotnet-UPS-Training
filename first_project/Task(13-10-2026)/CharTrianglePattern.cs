using System;

public class CharTrianglePattern
{
    public static void Main(String[] args)
    {
        
        Char alph = 'A';

        for(int i=1; i<=4; i++)
        {
            alph = 'A'; //reseting char value each time

            for(int j=1; j<=i; j++)
            {
                Console.Write(alph + " ");
                alph++; //increment A value 
            }
            Console.WriteLine();
        }

    }
}