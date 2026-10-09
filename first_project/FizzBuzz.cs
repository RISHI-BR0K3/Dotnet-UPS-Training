using System;

public class FizzBuzz
{
    public static void Main(String[] args)
    {
        
        //FizzBuzz
        for(int i=1; i<=30; i++)
        {

            if (i % 3 == 0)
            {
                if(i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine("Fizz");
                }
            }
            else if(i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }

        }

    }
}