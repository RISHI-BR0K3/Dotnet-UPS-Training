
using System;
using System.IO;

public class NameWrite
{
    public static void Main(string[] args)
    {
        String path = "Name";

        try
        {
            String text = "Hello World";

            // Create the file or overwrite its content
            File.WriteAllText(path, text);
            Console.WriteLine("File written successfully.");

            // Check whether the file exists
            if (File.Exists(path))
            {
                FileInfo info = new FileInfo(path);
                Console.WriteLine("File Size: " + info.Length + " bytes");
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
