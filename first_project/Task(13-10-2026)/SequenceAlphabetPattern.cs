using System;

public class SequenceAlphabetPattern
{
    public static void Main(String[] args)
    {
        
        Char alph = 'A';

        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(alph + " ");
                alph++;
            }
            Console.WriteLine();
        }

    }
}