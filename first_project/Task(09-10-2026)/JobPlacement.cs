using System;

public class JobPlacement
{
    public static void Main(String[] args)
    {
        
        Console.Write("Enter the score for aptitude: ");
        int aptitudeScore = Convert.ToInt32(Console.ReadLine());

        if(aptitudeScore > 70)
        {
            Console.WriteLine("You have been selected for technical round");
            Console.Write("Enter the score for technical round: ");
            int technicalScore = Convert.ToInt32(Console.ReadLine());

            if(technicalScore > 80)
            {
                Console.WriteLine("You have been selected for HR round");
                Console.Write("Enter the score for HR round: ");
                int hrScore = Convert.ToInt32(Console.ReadLine());

                if(hrScore > 80)
                {
                    Console.WriteLine("You have been selected for job");
                }
                else
                {
                    Console.WriteLine("You have not been selected for the job");
                }
            }
            else
            {
                Console.WriteLine("You did not got selected for HR round");
            }

        }
        else
        {
            Console.WriteLine("You have not been selected for technical round");
        }

    }
}