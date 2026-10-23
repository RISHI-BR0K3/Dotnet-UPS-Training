using System;

public class RPattern
{
    public static void Main(String[] args)
    {
        
        for(int i=1; i<=4; i++)
        {
            for(int j=1; j<=3; j++)
            {

                if((i==2) && (j==2) || (i==3) && (j==3) || (i==4) && (j == 2))
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