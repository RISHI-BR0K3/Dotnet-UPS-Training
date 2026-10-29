
using System;
using System.IO;

public class GetDirectory
{
    static string folderPath = Directory.GetCurrentDirectory();

    static string filePath = Path.Combine(folderPath, "sample.txt");

    public static void Main(string[] args)
    {
        Console.WriteLine("Current Directory: " + folderPath);
        Console.WriteLine("File Path: " + filePath);

        try
        {
            string text = "Combined file path with the folder path";

            File.WriteAllText(filePath, text);
            Console.WriteLine("File created successfully.");

            string content = File.ReadAllText(filePath);
            Console.WriteLine("File Content: " + content);
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.WriteLine("File handling over");
    }
}
