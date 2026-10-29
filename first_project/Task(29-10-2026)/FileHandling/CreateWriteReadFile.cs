using System;
using System.IO;

class CreateWriteReadFile
{
    static string folderPath = Directory.GetCurrentDirectory();
    static string filePath = Path.Combine(folderPath, "sample.txt");

    //write file
    static void WriteFile()
    {
        Console.WriteLine("Enter text to write in file: \n");
        string content = Console.ReadLine();

        File.AppendAllText(filePath, content);
    }

    //readfile
    static void ReadFile()
    {
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                String line;

                Console.WriteLine("File contents: \n");
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }

    //count words
    static void WordCount()
    {
        if (File.Exists(filePath))
        {
            int wordCount = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                String line;

                Console.WriteLine("File contents: \n");
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(" ");
                    wordCount += words.Length;
                }
                Console.WriteLine($"Total no of words = {wordCount}");
            }
        }
    }

    static void LineCount()
    {
        if (File.Exists(filePath))
        {
            int lineCount = 0;
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }
            Console.WriteLine($"Total Line = {lineCount}");
        }
    }

    public static void Main(String[] args)
    {

        // WriteFile();

        // ReadFile();

        // WordCount();

        LineCount();

    }

}