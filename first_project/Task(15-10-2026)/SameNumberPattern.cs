using System;

public class SameNumberPattern
{
    public static void Main(String[] args)
    
    {
        int num = 3;
        for(int i=1; i<=4; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write(num);
            }
            num++;
            Console.WriteLine();
        }
    }
}