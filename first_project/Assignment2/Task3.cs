using System;
using System.IO;

class NumberSumFile
{
    static void Main(String[] args)
    {
        String path = "Numbers.txt";

        try
        {
            Console.Write("How many numbers you want to write: ");
            int count = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter writer = new StreamWriter(path))
            {
                for(int i=1; i<=count; i++)
                {
                    Console.Write("Enter number " + i + ": ");
                    writer.WriteLine(Console.ReadLine());
                }
            }

            String[] lines = File.ReadAllLines(path);
            double sum = 0;

            Console.WriteLine("\nNumbers in file: ");
            foreach(string line in lines)
            {
                Console.WriteLine(line);
                sum += Convert.ToDouble(line);
            }

            Console.WriteLine($"Sum = {sum}");

        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
        }
        catch (FormatException)
        {
            Console.WriteLine("Enter numbers only");
        }
    }
}