using System;

public class ReverseSequenceAnother
{
    public static void Main(String[] args)
    {

        int num=15;

        for(int i=5; i >= 1; i--)
        {
            for(int j=1; j<=i; j++)
            {
                Console.Write(num + " ");
                num--;
            }
            Console.WriteLine();
        }
    }
}