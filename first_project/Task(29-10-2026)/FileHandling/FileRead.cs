
using System;
using System.IO;

public class FileRead
{
    public static void Main(string[] args)
    {
        String path = "Name";

        try
        {
            if (File.Exists(path))
            {
                String text = File.ReadAllText(path);
                Console.WriteLine("File Content: " + text);
            }
            else
            {
                Console.WriteLine("File Not Found");
            }
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory Not Found");
        }
        catch (IOException ex)
        {
            Console.WriteLine("File Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Filehandling over");
        }
    }
}
