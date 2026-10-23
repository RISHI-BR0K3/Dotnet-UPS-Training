using System;

public class Quadrant
{
    public static void Main(String[] args)
    {
        
        Console.Write("Enter the value for x: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value for y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        // I
        if(x>0 && y > 0)
        {
            Console.WriteLine("I quadrant");
        }
        // II
        else if(x<0 && y > 0)
        {
            Console.WriteLine("II quadrant");
        }
        // III
        else if(x<0 && y < 0)
        {
            Console.WriteLine("III quadrant");
        }
        // IV
        else
        {
            Console.WriteLine("IV quadrant");
        }

    }
}