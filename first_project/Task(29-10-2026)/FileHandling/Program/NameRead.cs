using System;
using System.IO;

public class NameRead
{
    public static void Main(String[] args)
    {
        try
        {
            String path = "Name";
            FileInfo info = new FileInfo(path);
            Console.WriteLine(info.Length);
            File.Exists(path);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File Not Found");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory Not Found");
        }
        catch (EndOfStreamException)
        {
            Console.WriteLine("File is Empty");
        }
        finally
        {
            Console.WriteLine("Filehandling over");
        }

    }
}