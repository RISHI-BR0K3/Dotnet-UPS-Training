using System;

public class GradeAnalyse
{
    public static void Main(String[] args)
    {
        
        Console.Write("Enter your mark outof 500: ");
        double mark = Convert.ToInt32(Console.ReadLine());

        if(mark <= 500)
        {
            
            double percentage = (mark / 500) * 100;

            if(percentage >= 90)
            {
                Console.WriteLine("Grade: S");
            }
            else if (percentage >= 80 && percentage < 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (percentage >= 70 && percentage < 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (percentage >= 60 && percentage < 70)
            {
                Console.WriteLine("Grade: C");
            }
            else if (percentage >= 50 && percentage < 60)
            {
                Console.WriteLine("Grade: D");
            }
            else if (percentage >= 40 && percentage < 50)
            {
                Console.WriteLine("Grade: E");
            }
            else if (percentage < 40)
            {
                Console.WriteLine("Grade: F");
            }

        }

    }
}