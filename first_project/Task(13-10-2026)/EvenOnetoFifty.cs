using System;
public class EvenOnetoFifty
{
    public static void Main(String[] args)
    {
        for(int i=1; i<=50; i++)
        {
            if(i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}