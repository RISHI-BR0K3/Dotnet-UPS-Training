using System;

public class CharacterTrianglePattern
{
    public static void Main(String[] args)
    {
        
        for(int i=0; i<5; i++){

            char ch = (char)('A' + i);

            for (int j = 0; j <= i; j++)
            {
                Console.Write((char)(ch + j) + " ");
            }

            Console.WriteLine();

        }

    }

}