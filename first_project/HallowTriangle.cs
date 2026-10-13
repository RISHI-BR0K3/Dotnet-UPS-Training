using System;

public class HallowTriangel
{
    public static void Main(String[] args)
    {
        
        for(int i=1; i<=4; i++)
        {
            for(int j=1; j<=i; j++)
            {
                
                if((i==3) && (j==2))
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write("* ");
                }

            }
            Console.WriteLine();
        }

    }

}